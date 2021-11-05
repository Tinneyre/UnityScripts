using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyController : MonoBehaviour {

    private Vector3 player;
    private Vector2 playerDirection;
    private float xdif;
    private float ydif;
    public float speed;

    public bool paused;
    public int pausedSpeed = 0;
    public int unpausedSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Submit"))
        {
            paused = !paused;
        }


        if (paused)
        {

            speed = pausedSpeed;
        }
        else if(!paused)
        {
            speed = unpausedSpeed;
        }


        player = GameObject.Find("Player").transform.position;
        xdif = player.x - transform.position.x;
        ydif = player.y - transform.position.y;

        playerDirection = new Vector2(xdif, ydif);

        gameObject.GetComponent<Rigidbody2D>().AddForce(playerDirection.normalized * speed);

    }
}
