using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCookingFire : MonoBehaviour {

    public GameObject fire;
	// Use this for initialization
	void Start () {

        fire.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LightFire()
        {
            fire.SetActive(true);
        }
    

}
