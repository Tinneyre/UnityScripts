using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    
    private SFXManager sfxMan;
    public PlayerStats thePS;

    // Use this for initialization
    void Start () {
        sfxMan = FindObjectOfType<SFXManager>();
        thePS = FindObjectOfType<PlayerStats>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
            {
                Destroy(gameObject);
                sfxMan.itemPickup.Play();
                thePS.GetKey();

            }
    }
}
