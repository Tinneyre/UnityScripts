using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldofView : MonoBehaviour {
    public SpriteRenderer fog;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Fog")
        {
            fog = other.gameObject.GetComponent<SpriteRenderer>();
            fog.color = new Color(fog.color.r, fog.color.g, fog.color.g, 0f);

           
        }
        else
        {

            
        }

     

        }
}
