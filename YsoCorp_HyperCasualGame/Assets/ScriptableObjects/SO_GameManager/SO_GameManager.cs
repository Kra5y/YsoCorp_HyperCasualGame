using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "SO_GameManager/GameManager")]
public class SO_GameManager : SO_Singleton<SO_GameManager>
{
    [SerializeField] private SOCharacterParameters SO_CharacterParameters;
    [SerializeField] private SO_PlayerInputs SO_PlayerInputs;
    [SerializeField] private SO_ObstaclesManager SO_ObstaclesManager;

    public bool IsGameOver;

    #region Static Getters
    public static SO_PlayerInputs PlayerInputs { get { return Instance.SO_PlayerInputs; } }
    public static SOCharacterParameters CharacterParameters { get { return Instance.SO_CharacterParameters; } }
    public static SO_ObstaclesManager ObstaclesManager { get { return Instance.SO_ObstaclesManager; } }
    #endregion

    public void GameOver()
    {
        IsGameOver = true;
        if(SO_CharacterParameters.Score > SO_CharacterParameters.BestScore)
        {
            SO_CharacterParameters.BestScore = SO_CharacterParameters.Score;
        }
        
    }

    public void NewGame()
    {
        SO_CharacterParameters.Score = 0;
        SceneManager.LoadScene(0);
    }

    public void ResetSO()
    {
        IsGameOver = false;
        SO_PlayerInputs.PlayerIsTouchingScreen = false;
        SO_PlayerInputs.JoystickDirection = Vector3.zero;
        SO_PlayerInputs.FingerCurrentPos = Vector3.zero;
        SO_PlayerInputs.FingerInitialPos = Vector3.zero;
        SO_CharacterParameters.Score = 0;
    }

}

