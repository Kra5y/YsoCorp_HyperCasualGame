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

}
