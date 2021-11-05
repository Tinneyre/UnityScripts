using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject monster;
    public Transform monsterSpawnPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            
            Destroy(gameObject);
            SpawnMonster();
            Debug.Log("spawn");
        }
    }

    public void SpawnMonster()
    {
        Instantiate(monster, monsterSpawnPoint.position, monsterSpawnPoint.rotation);
    }
}
