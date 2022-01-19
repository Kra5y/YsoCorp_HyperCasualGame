using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    [SerializeField] List<Obstacle> Obstacles = new List<Obstacle>();
    [SerializeField] List<Transform> SpawnPoints = new List<Transform>();

    [SerializeField] float TimeBetweenObstacles;
    float CurrentTimeBetweenObstacles;

    private void Start()
    {
        StartCoroutine(ObstacleSpawn());
    }

    IEnumerator ObstacleSpawn()
    {
        yield return new WaitForSeconds(TimeBetweenObstacles);
        Instantiate(Obstacles[Random.Range(0,Obstacles.Count)], SpawnPoints[Random.Range(0, SpawnPoints.Count)].position,Quaternion.identity);
        StartCoroutine(ObstacleSpawn());
    }

}
