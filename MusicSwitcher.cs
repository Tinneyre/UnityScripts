using UnityEngine;
using System.Collections;

public class MusicSwitcher : MonoBehaviour {

    private MusicController theMC;

    public int newTrack;

    public bool switchOnStart;

	// Use this for initialization
	void Start () {
        theMC = FindObjectOfType<MusicController>();

        if(switchOnStart)
        {
            theMC.SwitchTrack(newTrack);
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            theMC.SwitchTrack(newTrack);
           // gameObject.SetActive(false);
        }

    }
}
