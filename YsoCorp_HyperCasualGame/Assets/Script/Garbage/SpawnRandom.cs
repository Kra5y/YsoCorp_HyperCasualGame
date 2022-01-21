using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    [SerializeField] List<Obstacle> Obstacles = new List<Obstacle>();
    [SerializeField] Transform SpawnPoint;

    float CurrentTimeBetweenObstacles;

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
        yield return new WaitForSeconds(SO_GameManager.ObstaclesManager.TimeBetweenObstacles);
        Instantiate(Obstacles[Random.Range(0,Obstacles.Count)],SpawnPoint.position,Quaternion.identity);
        StartCoroutine(ObstacleSpawn());
    }

}
