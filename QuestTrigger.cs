using UnityEngine;
using System.Collections;

public class QuestTrigger : MonoBehaviour {

    private QuestManager theQM;

    public int questNumber;

    public bool startQuest;
    public bool endQuest;

    public bool findItem;
    public GameObject item;
    public bool makeAFriend;
    public GameObject monster;
    public EnemyController monsterCon;

	// Use this for initialization
	void Start () {
        theQM = FindObjectOfType<QuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(!theQM.questCompleted[questNumber])
            {
                if(startQuest && !theQM.quests[questNumber].gameObject.activeSelf)
                {
                    theQM.quests[questNumber].gameObject.SetActive(true);
                    theQM.quests[questNumber].StartQuest();
                    if(findItem == true)
                    {
                        item.SetActive(false);
                    }
                }
                
                if(endQuest && theQM.quests[questNumber].gameObject.activeSelf)
                {
                    theQM.quests[questNumber].EndQuest();
                    if(makeAFriend == true)
                    {
                        monster.SetActive(false);
                        monsterCon.Patrol();
                    }
                }
            }
        }
    }
}
