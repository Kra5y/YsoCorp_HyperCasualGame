using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("Obstacles Manager/SO_ObstaclesManager"))]
public class SO_ObstaclesManager : ScriptableObject
{
    [SerializeField] private float timeBetweenObstacles;
    [SerializeField] private float obstaclesSpeed;

    #region Getters

    public float TimeBetweenObstacles { get { return timeBetweenObstacles; } }
    public float ObstaclesSpeed { get { return obstaclesSpeed; } }


    #endregion
}
