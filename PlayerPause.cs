using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerPause : MonoBehaviour {

    private PlayerController playerCon;
    private Projectile projectile;
    public GameObject pauseBox;
    public bool paused;
	// Use this for initialization

        void Awake()
    {
      

    }
	void Start () {
        playerCon = GetComponent<PlayerController>();
        projectile = GetComponent<Projectile>();
	}
	
	// Update is called once per frame
	void Update () {
        if (paused == true)
        {
            pauseBox.SetActive(true);
          
        }
        if (paused == false)
        {
            pauseBox.SetActive(false);
           
        }
        if (Input.GetButtonUp("Submit"))
        {
            playerCon.enabled = !playerCon.enabled;
            projectile.enabled = !projectile.enabled;

            paused = !paused;
          
        }
	}
}
