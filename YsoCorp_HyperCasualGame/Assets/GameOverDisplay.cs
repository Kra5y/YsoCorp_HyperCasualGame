using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDisplay : MonoBehaviour
{
    [SerializeField] private RectTransform GameOverPanel;

    private void Update()
    {
        if (SO_GameManager.Instance.IsGameOver)
        {
            GameOverPanel.gameObject.SetActive(true);
        }
    }

}
