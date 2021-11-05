using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlePuzzle : MonoBehaviour {

    public bool candle1;
    public bool candle2;
    public bool candle3;
    public bool candle4;

    public GameObject candleFlame1;
    public GameObject candleFlame2;
    public GameObject candleFlame3;
    public GameObject candleFlame4;

    public GameObject puzzleItem;

    public SFXManager sfxMan;

    AudioSource m_MyAudioSource;

    //Play the music
    bool m_Play;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    bool m_ToggleChange;

    // Use this for initialization
    void Start () {
        candle1 = false;
        candle2 = false;
        candle3 = false;
        candle4 = false;

        sfxMan = FindObjectOfType<SFXManager>();
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }
	
	// Update is called once per frame
	void Update () {

        if(candle1 && candle2 && candle3 && candle4)
        {
            puzzleItem.SetActive(true);
           // sfxMan.success.Play();
            m_ToggleChange = true;
        }
        //Check to see if you just set the toggle to positive
        if (m_Play == true && m_ToggleChange == true)
        {
            //Play the audio you attach to the AudioSource component
            sfxMan.success.Play();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }
        //Check if you just set the toggle to false
        if (m_Play == false && m_ToggleChange == true)
        {
            //Stop the audio
            sfxMan.success.Stop();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }
    }
    
   public void Candle1SwitchActive()
    {
        if (!candle1)
        {
            candle1 = true;
            if (!candle2)
            {
                candle2 = true;
                candleFlame2.SetActive(true);
            }
            else if (candle2)
            {
                candle2 = false;
                candleFlame2.SetActive(false);
            }
            if (!candle4)
            {
                candle4 = true;
                candleFlame4.SetActive(true);
            }
            else if (candle4)
            {
                candle4 = false;
                candleFlame4.SetActive(false);
            }

            candleFlame1.SetActive(true);

        }
        else if (candle1)
        {
            candle1 = false;
            if (!candle2)
            {
                candle2 = true;
                candleFlame2.SetActive(true);
            }
            else if (candle2)
            {
                candle2 = false;
                candleFlame2.SetActive(false);
            }
            if (!candle4)
            {
                candle4 = true;
                candleFlame4.SetActive(true);
            }
            else if (candle4)
            {
                candle4 = false;
                candleFlame4.SetActive(false);
            }
            candleFlame1.SetActive(false);
        }
    }
    public void Candle2SwitchActive()
    {
        if (!candle2)
        {
            candle2 = true;
            if (!candle3)
            {
                candle3 = true;
                candleFlame3.SetActive(true);
            }
            else if (candle3)
            {
                candle3 = false;
                candleFlame3.SetActive(false);
            }
            if (!candle1)
            {
                candle1 = true;
                candleFlame1.SetActive(true);
            }
            else if (candle1)
            {
                candle1 = false;
                candleFlame1.SetActive(false);
            }

            candleFlame2.SetActive(true);

        }
        else if (candle2)
        {
            candle2 = false;
            if (!candle3)
            {
                candle3 = true;
                candleFlame3.SetActive(true);
            }
            else if (candle3)
            {
                candle3 = false;
                candleFlame3.SetActive(false);
            }
            if (!candle1)
            {
                candle1 = true;
                candleFlame1.SetActive(true);
            }
            else if (candle1)
            {
                candle1 = false;
                candleFlame1.SetActive(false);
            }
            candleFlame2.SetActive(false);
        }
    }
  public  void Candle3SwitchActive()
    {
        if (!candle3)
        {
            candle3 = true;
            if (!candle2)
            {
                candle2 = true;
                candleFlame2.SetActive(true);
            }
            else if (candle2)
            {
                candle2 = false;
                candleFlame2.SetActive(false);
            }
            if (!candle4)
            {
                candle4 = true;
                candleFlame4.SetActive(true);
            }
            else if (candle4)
            {
                candle4 = false;
                candleFlame4.SetActive(false);
            }

            candleFlame3.SetActive(true);

        }
        else if (candle3)
        {
            candle3 = false;
            if (!candle2)
            {
                candle2 = true;
                candleFlame2.SetActive(true);
            }
            else if (candle2)
            {
                candle2 = false;
                candleFlame2.SetActive(false);
            }
            if (!candle4)
            {
                candle4 = true;
                candleFlame4.SetActive(true);
            }
            else if (candle4)
            {
                candle4 = false;
                candleFlame4.SetActive(false);
            }
            candleFlame3.SetActive(false);
        }
    }
    public void Candle4SwitchActive()
    {
        if (!candle4)
        {
            candle4 = true;
            if (!candle3)
            {
                candle3 = true;
                candleFlame3.SetActive(true);
            }
            else if (candle3)
            {
                candle3 = false;
                candleFlame3.SetActive(false);
            }
            if (!candle1)
            {
                candle1 = true;
                candleFlame1.SetActive(true);
            }
            else if (candle1)
            {
                candle1 = false;
                candleFlame1.SetActive(false);
            }

            candleFlame4.SetActive(true);
            
        }
       else if (candle4)
        {
            candle4 = false;
            if (!candle3)
            {
                candle3 = true;
                candleFlame3.SetActive(true);
            }
            else if (candle3)
            {
                candle3 = false;
                candleFlame3.SetActive(false);
            }
            if (!candle1)
            {
                candle1 = true;
                candleFlame1.SetActive(true);
            }
            else if (candle1)
            {
                candle1 = false;
                candleFlame1.SetActive(false);
            }
            candleFlame4.SetActive(false);
        }
    }
}
