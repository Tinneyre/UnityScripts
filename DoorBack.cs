using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBack : MonoBehaviour {
    public GameObject room;
    public DungeonManager theDM;

	// Use this for initialization
	void Start () {
        theDM = FindObjectOfType<DungeonManager>();

	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Board")
        {
            gameObject.transform.position = new Vector3(theDM.columns, theDM.rows, 0f);
            Destroy(room);
            theDM.goingDown = false;
        }
    }
}
