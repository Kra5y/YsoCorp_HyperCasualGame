using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    [Header("Joystick Components")]
    [SerializeField] Image BG;
    [SerializeField] Image Handle;

    Vector3 HandleStartingPos;

    private void Start()
    {
        HandleStartingPos = Handle.transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        SO_GameManager.PlayerInputs.FingerCurrentPos = eventData.position;
        SO_GameManager.PlayerInputs.PlayerIsTouchingScreen = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SO_GameManager.PlayerInputs.FingerInitialPos = eventData.position;
        BG.transform.position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SO_GameManager.PlayerInputs.PlayerIsTouchingScreen = false;
        SO_GameManager.PlayerInputs.BreakForce = true;
        BG.transform.position = HandleStartingPos;
        Handle.transform.position = HandleStartingPos;
    }

    private void Update()
    {
        if (SO_GameManager.PlayerInputs.PlayerIsTouchingScreen)
        {
            Vector3 Offset = SO_GameManager.PlayerInputs.FingerCurrentPos - SO_GameManager.PlayerInputs.FingerInitialPos;

            SO_GameManager.PlayerInputs.JoystickDirection = Vector3.ClampMagnitude(Offset, BG.preferredWidth) / BG.preferredWidth;
            SO_GameManager.PlayerInputs.JoystickDirection.z = 0;
            Handle.transform.position = new Vector3(SO_GameManager.PlayerInputs.FingerInitialPos.x + Vector3.ClampMagnitude(Offset, BG.preferredWidth / 2).x, SO_GameManager.PlayerInputs.FingerInitialPos.y + Vector3.ClampMagnitude(Offset, BG.preferredHeight / 2).y, 0);
        }
    }
}
