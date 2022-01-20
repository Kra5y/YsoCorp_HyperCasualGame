using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterParameters", menuName = "SO_CharacterParameters")]
public class SOCharacterParameters : ScriptableObject
{
    [SerializeField] private float speed;

    public float Speed { get { return speed; } }
}
