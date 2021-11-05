using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MagicManager : MonoBehaviour {

    public int maxMagic;
    public float currentMagic;
    public float magicRegenSpeed;

    public bool fireMagicActive;
    public bool earthMagicActive;
    public bool airMagicActive;
    public bool waterMagicActive;

    private PlayerStats thePS;
    // Use this for initialization
    void Start () {

        currentMagic = maxMagic;

        thePS = FindObjectOfType<PlayerStats>();

	}

    // Update is called once per frame
    void Update() {

        if (currentMagic > maxMagic)
        {
            currentMagic = maxMagic;
        }
        if (currentMagic < maxMagic)
        {
            currentMagic += Time.deltaTime * magicRegenSpeed;
        }
        if (currentMagic < 0)
        {
            currentMagic = 0;
        }



        if (CrossPlatformInputManager.GetButtonDown("MagicSwitcher"))
        {
            if(fireMagicActive)
            {
                fireMagicActive = false;
                earthMagicActive = true;
            }
            else if (earthMagicActive)
            {
                earthMagicActive = false;
                airMagicActive = true;
            }
            else if (airMagicActive)
            {
                airMagicActive = false;
                waterMagicActive = true;
            }
            else if (waterMagicActive)
            {
                waterMagicActive = false;
                fireMagicActive = true;
            }
        }
}
    public void UseMagic (float mpToUse)
    {
        currentMagic -= mpToUse;
    }
}
