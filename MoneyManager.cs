using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour {

    public int moneyCount;
    public int moneyDecrease = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(moneyCount <= 0)
        {
            moneyCount = 0;
        }
	}

    public void AddMoney(int moneyToGive)
    {
        moneyCount += moneyToGive;
    }

    public void SubtractMoney(int moneyToTake)
    {
        moneyCount -= moneyToTake;
    }


}
