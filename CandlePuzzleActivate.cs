using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlePuzzleActivate : MonoBehaviour {

    public CandlePuzzle candlePuzzle;
	// Use this for initialization
	void Start () {
        candlePuzzle = FindObjectOfType<CandlePuzzle>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Candle1Active()
    {
        candlePuzzle.Candle1SwitchActive();
    }
    public void Candle2Active()
    {
        candlePuzzle.Candle2SwitchActive();
    }
    public void Candle3Active()
    {
        candlePuzzle.Candle3SwitchActive();
    }
    public void Candle4Active()
    {
        candlePuzzle.Candle4SwitchActive();
    }

}
