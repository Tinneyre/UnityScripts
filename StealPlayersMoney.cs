using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealPlayersMoney : MonoBehaviour {
    public int moneyToTake;
    private int currentMoney;
    public SFXManager sfxMan;
   
    // Use this for initialization
    void Start () {
        sfxMan = FindObjectOfType<SFXManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Player")
        {
            currentMoney = moneyToTake;
            if (currentMoney < 0)
            {
                currentMoney = 1;
            }

            other.gameObject.GetComponent<MoneyManager>().SubtractMoney(currentMoney);
            sfxMan.itemPickup.Play();
      
        }
    }
}
