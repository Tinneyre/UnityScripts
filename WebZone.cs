using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebZone : MonoBehaviour {
    public int webMaxHealth;
    public int webCurrentHealth;

    public PlayerStats thePlayerStats;

    public PlayerController pController;

    public float slowSpeed;

    private float destroyTimer = 15f;
    public float destroyCounter;


	// Use this for initialization
	void Start () {

        webCurrentHealth = webMaxHealth;

        pController = FindObjectOfType<PlayerController>();
        thePlayerStats = FindObjectOfType<PlayerStats>();
   
    }
	
	// Update is called once per frame
	void Update () {
        destroyTimer -= Time.deltaTime;
        if (destroyTimer < 0)
        {
            pController.moveSpeed = 5f;
            Destroy(gameObject);
        }
        if (webCurrentHealth <= 0)
        {
            Destroy(gameObject);
            pController.moveSpeed = 5f;      
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            pController.moveSpeed = slowSpeed;

        }

     }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            pController.moveSpeed = 5f;
        }
    }
    public void HurtEnemy(int damageToGive)
    {
        webCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        webCurrentHealth = webMaxHealth;
    }
}
