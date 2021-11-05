using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Projectile : MonoBehaviour {

    public GameObject projectilePrefab;
    private List<GameObject> Projectiles = new List<GameObject>();

    public float projectileVelocity;
    public Transform launchPoint;

    public float fireDelay = 1f;
    float cooldownTimer = 0;

    public int ammoMaxCount;
    public int ammoCurrentCount;
    private int ammoDecrease = 1;

    // Use this for initialization
    void Start () {


		
	}

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (CrossPlatformInputManager.GetButton("Shoot"))
        {
            Debug.Log("Pew");



            if (ammoCurrentCount > 0)
            {
                if (cooldownTimer <= 0)
                {

                    cooldownTimer = fireDelay;
                    Instantiate(projectilePrefab, launchPoint.position, launchPoint.rotation);
                    ammoCurrentCount -= ammoDecrease;

                }
            }
        }
        if(ammoCurrentCount > ammoMaxCount)
        {
            ammoCurrentCount = ammoMaxCount;
        }
    }

        public void AddAmmo(int ammoToGive)
            {
                ammoCurrentCount += ammoToGive;
            }
        
    }

