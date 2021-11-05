using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HagTransform : MonoBehaviour {


    public GameObject oldLady;
    public GameObject hag;

    public string dialogue;
    private DialogueManager dMan;

    public string[] dialogueLines;

    // Use this for initialization
    void Start() {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Fire")
        {

            dMan = FindObjectOfType<DialogueManager>();
            {
                //dMan.ShowBox(dialogue);

                if (!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }

                /* if(transform.parent.GetComponent<VillagerMovement>() != null)
                 {
                     transform.parent.GetComponent<VillagerMovement>().canMove = false;
                 }*/

            }
            Destroy(oldLady);
            hag.SetActive(true);
        }
    }
}
