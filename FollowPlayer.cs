using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;
    public PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        followTarget = player.gameObject;    
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            followTarget = other.gameObject;
            targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
            //transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
    }
}
