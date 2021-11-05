using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTransport : MonoBehaviour {

    public Transform currentCheckpoint;
   // public DungeonManager theDM;
  //  public GameObject room;
   
	// Use this for initialization
	void Start () {
      //  theDM = FindObjectOfType<DungeonManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = currentCheckpoint.transform.position;
        }
        /*if(other.gameObject.name == "Board")
        {
            gameObject.transform.position = new Vector3(theDM.columns, theDM.rows, 0f);
            Destroy(room);
        }*/
    }
}
