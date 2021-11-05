using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPause : MonoBehaviour {

    public EnemyController enemyCon;

    public GameObject enemy;
    public bool isShooter;


    // Use this for initialization

    void Start()
    {
       
        enemyCon.GetComponent<EnemyController>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonUp("Submit"))
        {

            enemyCon.enabled = !enemyCon.enabled;
            if(isShooter == true)
            {
              
            }

        }
    }
}
