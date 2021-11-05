using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySenses : MonoBehaviour
{

    public EnemyController enemyCon;
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")

        {
            enemyCon.follow = true;
            enemyCon.patroling = false;
            enemyCon.target = other.gameObject;
        }
        if (other.gameObject.tag == "Projectile")
        {
            player = GameObject.Find("Player");
            enemyCon.follow = true;
            enemyCon.patroling = false;
            enemyCon.target = player.gameObject;
        }

    }
  
}
