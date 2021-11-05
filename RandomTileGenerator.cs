using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTileGenerator : MonoBehaviour {
    public GameObject[] tileSpawn;
    private bool isColliding;
    public Transform tilePoint;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        isColliding = false;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isColliding) return;
            isColliding = true;
            Destroy(gameObject);
            int objectIndex = Random.Range(0, tileSpawn.Length);
            Instantiate(tileSpawn[objectIndex], tilePoint.position, tilePoint.rotation);

            //Debug.Log("poop");
        }
    }
    }
