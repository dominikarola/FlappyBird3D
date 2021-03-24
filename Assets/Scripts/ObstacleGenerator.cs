using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;
    public float space = 3;
   
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            CreateObstacle();
        }
    }
    public void CreateObstacle()
    {
        Instantiate(obstacle, new Vector3(space, Random.Range(0.8f, 2.5f), 3), Quaternion.Euler(0,0,0));
        space += 3;
    }
}
