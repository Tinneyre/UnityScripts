using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCopy : MonoBehaviour {

    public DungeonManager theDM;
    public int level = 1;
    public Transform roomSpawnPoint;
    public Vector2 startDirection;
    private PlayerController player;
    public GameObject roomTrigger;
    public GameObject doorTransport;


    void Start()
    {
        theDM = FindObjectOfType<DungeonManager>();
        player = FindObjectOfType<PlayerController>();


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        float randomValue;
        randomValue = Random.value;
        if (other.gameObject.name == "PlayerFrontPoint")
        {
            if (startDirection.x == -1)
            {
                if (randomValue > .33)
                {
                    theDM.goingRight = false;
                    theDM.goingLeft = true;
                    theDM.goingUp = true;
                    theDM.goingDown = true;
                }


                theDM.comingLeft = true;
                theDM.comingRight = false;
                theDM.comingUp = false;
                theDM.comingDown = false;

                Debug.Log("Left");

            }
            if (startDirection.x == 1)
            {
                theDM.comingLeft = false;
                theDM.comingRight = true;
                theDM.comingUp = false;
                theDM.comingDown = false;

                theDM.goingRight = true;
                theDM.goingLeft = false;
                theDM.goingUp = true;
                theDM.goingDown = true;
                Debug.Log("Right");
            }
            if (startDirection.y == 1)
            {
                theDM.comingLeft = false;
                theDM.comingRight = false;
                theDM.comingUp = true;
                theDM.comingDown = false;

                theDM.goingRight = false;
                theDM.goingLeft = true;
                theDM.goingUp = true;
                theDM.goingDown = false;
                Debug.Log("Up");
            }
            if (startDirection.y == -1)
            {
                theDM.comingLeft = false;
                theDM.comingRight = false;
                theDM.comingUp = false;
                theDM.comingDown = true;

                theDM.goingRight = true;
                theDM.goingLeft = true;
                theDM.goingUp = false;
                theDM.goingDown = true;
                Debug.Log("Left");
            }
            // Destroy(gameObject);
            theDM.SetupScene(1);
            roomTrigger.SetActive(false);
            theDM.boardHolder.position = new Vector3(roomSpawnPoint.position.x, roomSpawnPoint.position.y, transform.position.z);
            theDM.InitialiseList();

            // theDM.comingLeft = true;

            doorTransport.transform.position = theDM.entranceSpawnPoint.transform.position;
            if (theDM.comingLeft == true)
            {
                // theDM.entranceSpawnPoint.position = new Vector3(theDM.columns, theDM.rows * .5f, 0f).transform.parent = theDM.boardHolder;


            }









        }

    }
    void Update()
    {
        startDirection = player.lastMove;
    }
}
