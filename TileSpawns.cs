using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawns : MonoBehaviour {
    public GameObject[] spawn;
    public Transform spawnPoint;
    public GameObject[] doorSpawn;



    // Use this for initialization
    void Start() {
        int objectIndex = Random.Range(0, spawn.Length);
        Instantiate(spawn[objectIndex], spawnPoint.position, spawnPoint.rotation);
      
    }
	
	// Update is called once per frame
	void Update () {
      
	}
}
