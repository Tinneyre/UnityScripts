using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCompletionTrigger : MonoBehaviour {

    private QuestManager theQM;
    public CircleCollider2D circleCollider;

	// Use this for initialization
	void Start () {

        theQM = FindObjectOfType<QuestManager>();
    }

	
	// Update is called once per frame
	void Update () {

        if(theQM.questCompleted[0])
        {
            circleCollider.GetComponent<CircleCollider2D>().enabled = false;
        }
		
	}
}
