using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUpRoom : MonoBehaviour
{

    public bool lightActive;
    public int candlesLit;
    
    public SpriteRenderer darknessSprite;
   

    // Use this for initialization
    void Start()
    {

        darknessSprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
       if(candlesLit <= 0)
        {
            darknessSprite.color = new Color(darknessSprite.color.r, darknessSprite.color.g, darknessSprite.color.g, 1f);
        }
            if (candlesLit > 0)
            {
               
                darknessSprite.color = new Color(darknessSprite.color.r, darknessSprite.color.g, darknessSprite.color.g, .75f);
                Debug.Log("candleLit");
            }
            if (candlesLit > 1)
            {
                darknessSprite.color = new Color(darknessSprite.color.r, darknessSprite.color.g, darknessSprite.color.g, .5f);
            }
            if (candlesLit > 2)
            {
                darknessSprite.color = new Color(darknessSprite.color.r, darknessSprite.color.g, darknessSprite.color.g, .25f);
            }
            if (candlesLit > 3)
            {
                darknessSprite.color = new Color(darknessSprite.color.r, darknessSprite.color.g, darknessSprite.color.g, 0f);
            }
        }
       
    

    public void LightCandle(int numberLit)
    {
        candlesLit += numberLit;
    }
    public void DimCandle(int numberLit)
    {
        candlesLit -= numberLit;
    }

}


