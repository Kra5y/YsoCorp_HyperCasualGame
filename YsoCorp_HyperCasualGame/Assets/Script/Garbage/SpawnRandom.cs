using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    [SerializeField] List<Obstacle> Obstacles = new List<Obstacle>();
    [SerializeField] Transform SpawnPoint;

    float CurrentTimeBetweenObstacles;
    private int PreviousIndex;

    private void Start()
    {
        StartCoroutine(ObstacleSpawn());
    }

    private void Update()
    {
        if (SO_GameManager.Instance.IsGameOver)
        {
            StopAllCoroutines();
        }
    }

    IEnumerator ObstacleSpawn()
    {
        int rnd = Random.Range(0, Obstacles.Count);
        yield return new WaitForSeconds(SO_GameManager.ObstaclesManager.TimeBetweenObstacles);
        if(Obstacles.Count > 1)
        {
            while (rnd == PreviousIndex)
            {
                rnd = Random.Range(0, Obstacles.Count);
            }
        }
        PreviousIndex = rnd;
        Instantiate(Obstacles[rnd],SpawnPoint.position,Quaternion.identity);
        StartCoroutine(ObstacleSpawn());
    }

}
