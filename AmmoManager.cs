using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour {


    private bool reloading;
    private int currentArrowCount;
    
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
           
            if (currentArrowCount < 0)
            {
                currentArrowCount = 1;
            }

        
            
            
            Destroy(gameObject);
        }
    }
}
