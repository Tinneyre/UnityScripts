using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public PlayerStats thePS;
    private SFXManager sfxMan;

	// Use this for initialization
	void Start () {
        thePS = FindObjectOfType<PlayerStats>();
        sfxMan = FindObjectOfType<SFXManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(thePS.keyPickup == true)
            {
                gameObject.SetActive(false);
                sfxMan.doorOpen.Play();
                thePS.UseKey();

            }
        }
    }
}
