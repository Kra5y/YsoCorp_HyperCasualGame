using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody Rb;
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Rb.velocity = Vector3.zero;
        if (SO_GameManager.PlayerInputs.BreakForce)
        {
            BreakForce();
        }
    }
    private void FixedUpdate()
    {
        if (SO_GameManager.PlayerInputs.PlayerIsTouchingScreen)
        {
            MovePlayer(SO_GameManager.PlayerInputs.JoystickDirection);
        }
    }

    public void MovePlayer(Vector3 direction)
    {
        Rb.MovePosition( this.transform.position + (direction * Time.deltaTime * SO_GameManager.CharacterParameters.Speed));
    }

    public void BreakForce()
    {
        Rb.MovePosition(this.transform.position);
        SO_GameManager.PlayerInputs.BreakForce = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colliding with wall");
    }

}
