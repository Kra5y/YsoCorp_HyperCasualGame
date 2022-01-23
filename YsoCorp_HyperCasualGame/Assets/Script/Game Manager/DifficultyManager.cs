using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(SO_GameManager.CharacterParameters.Score >= 0 && SO_GameManager.CharacterParameters.Score <= 10)
        {
            SO_GameManager.ObstaclesManager.Tier = 0;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 11 && SO_GameManager.CharacterParameters.Score <= 40)
        {
            SO_GameManager.ObstaclesManager.Tier = 1;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 41 && SO_GameManager.CharacterParameters.Score <= 65)
        {
            SO_GameManager.ObstaclesManager.Tier = 2;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 66 && SO_GameManager.CharacterParameters.Score <= 95)
        {
            SO_GameManager.ObstaclesManager.Tier = 3;
        }
        else if(SO_GameManager.CharacterParameters.Score >= 96 && SO_GameManager.CharacterParameters.Score <= 136)
        {
            SO_GameManager.ObstaclesManager.Tier = 4;
        }
        else if (SO_GameManager.CharacterParameters.Score >= 166 && SO_GameManager.CharacterParameters.Score <= 200)
        {
            SO_GameManager.ObstaclesManager.Tier = 5;
        }
        else if (SO_GameManager.CharacterParameters.Score >= 201 && SO_GameManager.CharacterParameters.Score <= 399)
        {
            SO_GameManager.ObstaclesManager.Tier = 6;
        }
        else if (SO_GameManager.CharacterParameters.Score >= 400)
        {
            SO_GameManager.ObstaclesManager.Tier = 7;
        }
    }
}
