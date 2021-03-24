using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpHeight;

    Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        playerRb.velocity = new Vector3(speed, playerRb.velocity.y, playerRb.velocity.z); 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.velocity = new Vector3(speed, playerRb.velocity.y + jumpHeight, playerRb.velocity.z);
        }

        if(transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            playerRb.velocity = new Vector3(playerRb.velocity.x, 0, 0);
        }
        else if(transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4, transform.position.z);
            playerRb.velocity = new Vector3(playerRb.velocity.x, 0, 0);
        }

    }
}
