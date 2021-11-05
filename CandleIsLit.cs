using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleIsLit : MonoBehaviour {

    public bool lightActive;
    public float candleLitTimer;

    public GameObject flame;

    public LightUpRoom lightUpRoom;

    private int candleNumber = 1;
    

	// Use this for initialization
	void Start () {
        lightUpRoom = FindObjectOfType<LightUpRoom>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (candleLitTimer <= 0)
        {
            lightActive = false;
           
        }
        if (candleLitTimer > 0)
        {
            lightActive = true;
            StartTimer();
            

        }*/
    }
    public void LightCandle(float candleTime)
    {
        candleLitTimer += candleTime;
        lightUpRoom.GetComponent<LightUpRoom>().LightCandle(candleNumber);
        flame.SetActive(true);
    }
    private void StartTimer()
    {
        candleLitTimer -= Time.deltaTime;
        
    }
}


