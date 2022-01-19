using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterParameters", menuName = "SO_CharacterParameters")]
public class SOCharacterParameters : ScriptableObject
{
    public bool IsTouchingScreen;
    public float YOffset;
}
