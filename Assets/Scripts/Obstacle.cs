using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    ObstacleGenerator obstacleGenerator;

    private void Start()
    {
        obstacleGenerator = FindObjectOfType<ObstacleGenerator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        obstacleGenerator.CreateObstacle();
        Debug.Log("przeszlo");
    }
}
