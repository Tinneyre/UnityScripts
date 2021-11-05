using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPack : MonoBehaviour {
    public EnemyController[] enemyCons;
    public GameObject[] wolves;
    // Use this for initialization
    void Start () {
     
   
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject[] wolves = GameObject.FindGameObjectsWithTag("Wolf");
            foreach (GameObject wolve in wolves)
            {
                enemyCons = wolve.gameObject.GetComponents<EnemyController>();
                foreach (EnemyController enemyCon in enemyCons)
                {
                    enemyCon.follow = true;
                    enemyCon.patroling = false;
                    enemyCon.target = other.gameObject;
                }
                }
        }
    }
}
