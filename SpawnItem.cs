using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour {

    public GameObject[] itemSpawn;
    private bool isColliding;
    public Transform spawnPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        isColliding = false;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            if (isColliding) return;
            isColliding = true;
            Destroy(gameObject);
            int objectIndex = Random.Range(0, itemSpawn.Length);
            Instantiate(itemSpawn[objectIndex], spawnPoint.position, spawnPoint.rotation);
            
            
        }
    }
}
