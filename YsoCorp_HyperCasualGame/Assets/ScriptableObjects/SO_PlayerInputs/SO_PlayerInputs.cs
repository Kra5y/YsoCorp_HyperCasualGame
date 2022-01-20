using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Inputs/SO_PlayerInputs")]
public class SO_PlayerInputs : ScriptableObject
{
    public Vector3 FingerInitialPos;
    public Vector3 FingerCurrentPos;

    public Vector3 JoystickDirection;

    public bool PlayerIsTouchingScreen;

    public bool BreakForce;

    private void Awake()
    {
        FingerInitialPos = Vector3.zero;
        FingerCurrentPos = Vector3.zero;
        JoystickDirection = Vector3.zero;

        PlayerIsTouchingScreen = false;
    }

}
