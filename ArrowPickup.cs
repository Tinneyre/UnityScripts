using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPickup : MonoBehaviour
{


   
    private int currentAmmo;
   
    public int ammoToGive;


    private Projectile projectile;

    // Use this for initialization
    void Start()
    {
        projectile = FindObjectOfType<Projectile>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            currentAmmo = ammoToGive;
            if (currentAmmo < 0)
            {
                currentAmmo = 1;
            }

            other.gameObject.GetComponent<Projectile>().AddAmmo(currentAmmo);
           
            Destroy(gameObject);
        }
    }
}