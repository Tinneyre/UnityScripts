using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebShooter : MonoBehaviour {

    public Transform firePoint;
    public GameObject web;

    public float webShotCounter;
    public float webTimer;

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        webShotCounter -= Time.deltaTime;
		if(webShotCounter < 0)
        {
            Instantiate(web, firePoint.position, firePoint.rotation);
            ResetTimer();

        }
	}
    void ResetTimer()
    {
        webShotCounter = webTimer;
    }
}
