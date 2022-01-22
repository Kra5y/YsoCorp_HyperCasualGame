using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(SO_GameManager.CharacterParameters.Score >= 0 && SO_GameManager.CharacterParameters.Score <= 20)
        {
            SO_GameManager.ObstaclesManager.Tier = 0;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 21 && SO_GameManager.CharacterParameters.Score <= 50)
        {
            SO_GameManager.ObstaclesManager.Tier = 1;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 51 && SO_GameManager.CharacterParameters.Score <= 80)
        {
            SO_GameManager.ObstaclesManager.Tier = 2;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 81 && SO_GameManager.CharacterParameters.Score <= 120)
        {
            SO_GameManager.ObstaclesManager.Tier = 3;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 121 && SO_GameManager.CharacterParameters.Score <= 160)
        {
            SO_GameManager.ObstaclesManager.Tier = 4;
        }
        else if (SO_GameManager.CharacterParameters.Score >= 161 && SO_GameManager.CharacterParameters.Score <= 200)
        {
            SO_GameManager.ObstaclesManager.Tier = 5;
        }
        else if (SO_GameManager.CharacterParameters.Score >= 201 && SO_GameManager.CharacterParameters.Score <= 250)
        {
            SO_GameManager.ObstaclesManager.Tier = 6;
        }
        else if (SO_GameManager.CharacterParameters.Score >= 251 && SO_GameManager.CharacterParameters.Score <= 300)
        {
            SO_GameManager.ObstaclesManager.Tier = 7;
        }
    }
}
