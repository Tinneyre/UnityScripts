using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FireMagic : MonoBehaviour {

    public GameObject sparkBurst;
    public Transform sparkPoint;
    public GameObject sparkActive;
    public float sparkTimer;
    public float sparkTime;
    public float magicCost;

    private MagicManager magicMan;


    
	// Use this for initialization
	void Start () {

        magicMan = FindObjectOfType<MagicManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
   
            if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))

            {
                if (magicMan.currentMagic > 10)
                   {
                        Instantiate(sparkBurst, sparkPoint.position, sparkPoint.rotation);
                        sparkActive.SetActive(true);
                        sparkTimer += sparkTime;

                        magicMan.UseMagic(magicCost);
                   }

            }

            if (sparkTimer <= 0)
        {
            sparkActive.SetActive(false);
        }
            if(sparkTimer >= 0)
        {
            sparkTimer -= Time.deltaTime;
        }
       
    }
    private void StartTimer()
    {
        sparkTimer -= Time.deltaTime;

    }
}
