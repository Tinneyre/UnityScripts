using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPause : MonoBehaviour {

    public VillagerMovement villager;




    // Use this for initialization

    void Start()
    {

        villager.GetComponent<VillagerMovement>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonUp("Submit"))
        {

            villager.enabled = !villager.enabled;

        }
    }
}
