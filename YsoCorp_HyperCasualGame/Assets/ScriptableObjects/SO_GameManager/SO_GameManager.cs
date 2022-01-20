using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO_GameManager/GameManager")]
public class SO_GameManager : SO_Singleton<SO_GameManager>
{
    [SerializeField]
    private SOCharacterParameters SO_CharacterParameters;
    [SerializeField]
    private SO_PlayerInputs SO_PlayerInputs;

    public static SO_PlayerInputs PlayerInputs { get { return Instance.SO_PlayerInputs; } }
    public static SOCharacterParameters CharacterParameters { get { return Instance.SO_CharacterParameters; } }
}
