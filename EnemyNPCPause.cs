using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNPCPause : MonoBehaviour {

    private EnemyController enemyCon;
    public bool enemy;
    
  
    
   
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
     
        }
    }
}
