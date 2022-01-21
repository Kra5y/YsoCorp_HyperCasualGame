using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!SO_GameManager.Instance.IsGameOver)
        {
            Destroy(collision.collider.gameObject);
            SO_GameManager.CharacterParameters.Score++;
        }
    }
}
