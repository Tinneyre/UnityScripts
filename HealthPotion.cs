using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour {


    private bool reloading;
    private int currentHeal;
    public GameObject healNumber;
    public int healthToGive;
    

    private PlayerStats thePS;

    // Use this for initialization
    void Start()
    {
        thePS = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            currentHeal = healthToGive;
            if (currentHeal < 0)
            {
                currentHeal = 1;
            }

            other.gameObject.GetComponent<PlayerHealthManager>().HealPlayer(currentHeal);
            var clone = (GameObject)Instantiate(healNumber, other.transform.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentHeal;
            Destroy(gameObject);
        }
    }
}
