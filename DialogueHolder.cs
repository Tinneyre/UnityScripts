using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class DialogueHolder : MonoBehaviour {

    public string dialogue;
    private DialogueManager dMan;

    public string[] dialogueLines;

   // public GameObject buttonPress;

	// Use this for initialization
	void Start () {

        dMan = FindObjectOfType<DialogueManager>();
        //buttonPress = GameObject.FindGameObjectWithTag("Button");
	
	}
    private void Awake()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update () {
	
	}
   
    void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.gameObject.name == "Player")
        {
            buttonPress.SetActive(false);
        }
        else
        {
            buttonPress.SetActive(true);
        }*/


        if (other.gameObject.name == "Player")
        {
            
           // if(CrossPlatformInputManager.GetButtonDown("Dash"))
           // {
                //dMan.ShowBox(dialogue);

                if(!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }

               /* if(transform.parent.GetComponent<VillagerMovement>() != null)
                {
                    transform.parent.GetComponent<VillagerMovement>().canMove = false;
                }*/

           // }
     
        }
     
    }
}

