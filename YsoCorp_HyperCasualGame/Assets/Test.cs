using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    private TextMeshProUGUI Text;
    private void Start()
    {
        Text = this.GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        Text.text = SO_GameManager.CharacterParameters.IsTouchingScreen.ToString();
    }
}
