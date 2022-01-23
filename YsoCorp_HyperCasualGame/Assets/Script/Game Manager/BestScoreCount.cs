using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreCount : MonoBehaviour
{
    private TextMeshProUGUI BestScoreDisplay;


    // Start is called before the first frame update
    void Start()
    {
        BestScoreDisplay = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        BestScoreDisplay.text = "Best Score : " + SO_GameManager.CharacterParameters.BestScore.ToString();
    }
}
