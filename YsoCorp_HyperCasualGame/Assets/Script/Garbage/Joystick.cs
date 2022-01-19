using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] Image BG;
    [SerializeField] Image Handle;
    [SerializeField] GameObject Player;
    [SerializeField] float speed;
    [SerializeField] Rigidbody Rb;
    Vector3 InitialPos, StartPos, EndPos,Dir;
    bool JoystickPressed;

    private void Start()
    {
        InitialPos = Handle.transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        EndPos = eventData.position;
        SO_GameManager.CharacterParameters.IsTouchingScreen = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        StartPos = eventData.position;
        BG.transform.position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SO_GameManager.CharacterParameters.IsTouchingScreen = false;
        BG.transform.position = InitialPos;
        Handle.transform.position = InitialPos;
        BreakForce();


    }

    private void Update()
    {
        if (SO_GameManager.CharacterParameters.IsTouchingScreen)
        {
            Vector3 Offset = EndPos - StartPos;
           
            Vector3 Direction = Vector3.ClampMagnitude(Offset,250f) / 250;
            Debug.Log(Direction.magnitude);
            Direction.z = 0;
            Dir = Direction;
            Handle.transform.position = new Vector3(StartPos.x + Vector3.ClampMagnitude(Offset,BG.preferredWidth/2).x,StartPos.y + Vector3.ClampMagnitude(Offset,BG.preferredHeight / 2).y,0);
        }
    }

    private void FixedUpdate()
    {

        if (SO_GameManager.CharacterParameters.IsTouchingScreen)
        {
            PlayerMove(Dir);
        }
    }
    private void PlayerMove(Vector3 Direction)
    {
        Rb.MovePosition(Player.transform.position + (Direction * Time.deltaTime * speed));
    }

    private void BreakForce()
    {
        Rb.AddForce(-Rb.velocity, ForceMode.VelocityChange);
    }

}
