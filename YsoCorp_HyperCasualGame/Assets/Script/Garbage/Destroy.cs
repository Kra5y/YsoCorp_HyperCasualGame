using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!SO_GameManager.Instance.IsGameOver && other.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            SO_GameManager.CharacterParameters.Score++;
        }
    }

}
