using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SparkSpell : MonoBehaviour {

   // public GameObject burnableObj;
   // public GameObject sparkBurst;
    public Transform sparkPoint;
    public GameObject flame;

    //private BurnableObject burnableObjScript;
    public int burnDamage;
    public int burnTime = 10;

    public int candleTime = 15;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	/*void Update () {
        if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
        {
            Instantiate(sparkBurst, sparkPoint.position, sparkPoint.rotation);
        }
       
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "BurnableObject")
        {
            
           
            Instantiate(flame, sparkPoint.position, sparkPoint.rotation);
            other.gameObject.SetActive(false);
            /* if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
             {
                 burnableObj.SetActive(false);
                 Instantiate(flame, sparkPoint.position, sparkPoint.rotation);
             }*/
            Debug.Log("burn");

        }
        if (other.gameObject.tag == "Web")
        {
            
            other.gameObject.GetComponent<WebZone>().HurtEnemy(burnDamage);
            Instantiate(flame, sparkPoint.position, sparkPoint.rotation);
          
            other.gameObject.SetActive(false);
        

            /*if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
            {
                other.gameObject.GetComponent<WebZone>().HurtEnemy(burnDamage);
                Instantiate(flame, sparkPoint.position, sparkPoint.rotation);
            }*/

        }
        if(other.gameObject.tag == "Candle")
        {
           
            other.gameObject.GetComponent<LightUpCircle>().LightCandle(candleTime);

            /*if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
            {
                other.gameObject.GetComponent<LightUpCircle>().LightCandle(candleTime);
            }*/
        }
        if (other.gameObject.tag == "Candle1")
        {
        
            other.gameObject.GetComponent<CandlePuzzleActivate>().Candle1Active();

            /*if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
            {
                other.gameObject.GetComponent<CandlePuzzleActivate>().Candle1Active();
            }*/
        }
     
        if (other.gameObject.tag == "Candle2")
        {
            
            other.gameObject.GetComponent<CandlePuzzleActivate>().Candle2Active();

            /*if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
            {
                other.gameObject.GetComponent<CandlePuzzleActivate>().Candle2Active();
            }*/
        }
        if (other.gameObject.tag == "Candle3")
        {
        
            other.gameObject.GetComponent<CandlePuzzleActivate>().Candle3Active();

           /* if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
            {
                other.gameObject.GetComponent<CandlePuzzleActivate>().Candle3Active();
            }*/
        }
        if (other.gameObject.tag == "Candle4")
        {
        
            other.gameObject.GetComponent<CandlePuzzleActivate>().Candle4Active();

            /*if (CrossPlatformInputManager.GetButtonDown("SparkSpell"))
            {
                other.gameObject.GetComponent<CandlePuzzleActivate>().Candle4Active();
            }*/
        }
        if(other.gameObject.tag == "Cooking Fire")
        {
            other.gameObject.GetComponent<LightCookingFire>().LightFire();
        }
    }
}
