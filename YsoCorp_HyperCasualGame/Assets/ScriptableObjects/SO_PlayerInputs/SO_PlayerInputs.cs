using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Inputs/SO_PlaeyrInputs")]
public class SO_PlayerInputs : ScriptableObject
{
    public Vector3 FingerInitialPos;
    public Vector3 FingerCurrentPos;

    public Vector3 JoystickDirection;

    public bool PlayerIsTouchingScreen;
}
