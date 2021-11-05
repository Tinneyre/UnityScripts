using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickUp : MonoBehaviour {


    private int currentMoney;

    public int moneyToGive;


    private Projectile projectile;

    private SFXManager sfxMan;

    // Use this for initialization
    void Start()
    {
        projectile = FindObjectOfType<Projectile>();
        sfxMan = FindObjectOfType<SFXManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            currentMoney = moneyToGive;
            if (currentMoney < 0)
            {
                currentMoney = 1;
            }

            other.gameObject.GetComponent<MoneyManager>().AddMoney(currentMoney);
            sfxMan.itemPickup.Play();
            Destroy(gameObject);
        }
    }
}
