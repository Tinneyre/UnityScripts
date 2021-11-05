﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

    public string levelToLoad;

    public string exitPoint;

    private PlayerController thePlayer;
    
    void Start ()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
            thePlayer.startPoint = exitPoint;
        }
    }
}
