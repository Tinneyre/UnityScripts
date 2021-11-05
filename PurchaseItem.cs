using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseItem : MonoBehaviour {

    public int moneyToTake;
    private int currentMoney;
    public SFXManager sfxMan;
    public Text displayNumber;
	// Use this for initialization
	void Start () {
        sfxMan = FindObjectOfType<SFXManager>();
	}
	
	// Update is called once per frame
	void Update () {
        displayNumber.text = "" + moneyToTake;
    }

    void OnTriggerEnter2D (Collider2D other)
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
            Destroy(gameObject);
          //  transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
