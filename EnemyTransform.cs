using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class EnemyTransform : MonoBehaviour {


    public GameObject originalMonster;
    public GameObject transformedMonster;
	// Use this for initialization
	void Start () {
        transformedMonster.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetButtonDown("Attack"))
        {
            MonsterTransform();
            Destroy(gameObject);
        }
    }

    public void MonsterTransform()
    {
        originalMonster.SetActive(false);
        transformedMonster.SetActive(true);
    }

  
          
        
    
}
