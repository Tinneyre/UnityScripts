using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour {

    public EnemyController enemyCon;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            enemyCon.GetComponent<EnemyController>().FollowTarget();
        }
        else
        {
            enemyCon.GetComponent<EnemyController>().Patrol();
        }
    }
}
