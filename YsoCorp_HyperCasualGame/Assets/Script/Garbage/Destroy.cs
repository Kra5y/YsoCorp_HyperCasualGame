using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Score;
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        score++;
        Score.text = "Score : " + score;
    }
}
