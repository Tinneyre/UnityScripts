using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUpCircle : MonoBehaviour {

    public SpriteRenderer darkCircle;

    public float candleTimer;

    public bool lightActive;
    private bool spawnCandle;

    public GameObject flame;
    public Transform flamePoint;

	// Use this for initialization
	void Start () {

        darkCircle = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frame
    void Update() {     
        if (candleTimer <= 0)
        {
            lightActive = false;
            darkCircle.color = new Color(darkCircle.color.r, darkCircle.color.g, darkCircle.color.g, .9f);
            flame.SetActive(false);
        }
        if (candleTimer > 0)
        {
            lightActive = true;
            StartTimer(); 
            if (lightActive)
            {
                darkCircle.color = new Color(darkCircle.color.r, darkCircle.color.g, darkCircle.color.g, 0f);
                flame.SetActive(true);
            } 

        }
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        /*if(other.gameObject.tag == "Fire")
        {
            Instantiate(flame, flamePoint.position, flamePoint.rotation);
        }*/
    }
    public void LightCandle(float candleTime)
    {
        candleTimer += candleTime;
    }
    private void StartTimer()
    {
        candleTimer -= Time.deltaTime;
    }
}
