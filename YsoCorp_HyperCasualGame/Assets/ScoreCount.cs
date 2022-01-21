using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    private TextMeshProUGUI ScoreDisplay;

    private void Start()
    {
        ScoreDisplay = this.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ScoreDisplay.text = "Score : " + SO_GameManager.CharacterParameters.Score.ToString();
    }

}
