using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour {

    public float speed;

    public PlayerController player;

    private Rigidbody2D myrigidbody2D;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        myrigidbody2D = GetComponent<Rigidbody2D>();

        if(player.transform.position.x < transform.position.x)
        {
            speed = -speed;
        }
    }

   
}
