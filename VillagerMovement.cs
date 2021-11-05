using UnityEngine;
using System.Collections;

public class VillagerMovement : MonoBehaviour {

    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    public bool paused;

    private Rigidbody2D myRigidBody;

    public bool isWalking;

    public float walkTime;
    public float waitTime;
    private float walkCounter;
    private float waitCounter;

    private int walkDirection;

    public Collider2D walkZone;
    private bool hasWalkZone;

    public bool canMove;
    private DialogueManager dMan;

    public int unpausedSpeed;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        dMan = FindObjectOfType<DialogueManager>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();

        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }

        canMove = true;
	}
	
	// Update is called once per frame
	void Update () {

        if(dMan.dialogueActive)
        {
            moveSpeed = 0;
        }
        else if(!dMan.dialogueActive)
        {
            moveSpeed = unpausedSpeed;
        }
       

        if(!canMove)
        {
            myRigidBody.velocity = Vector2.zero;
            return;
        }

	    if (isWalking)
        {
            walkCounter -= Time.deltaTime;
           
            switch(walkDirection)
            {
                case 0:
                    myRigidBody.velocity = new Vector2(0, moveSpeed);
                    if(hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 1:
                    myRigidBody.velocity = new Vector2( moveSpeed, 0);
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 2:
                    myRigidBody.velocity = new Vector2(0, -moveSpeed);
                    if (hasWalkZone && transform.position.y < minWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 3:
                    myRigidBody.velocity = new Vector2(-moveSpeed, 0);
                    if (hasWalkZone && transform.position.x < minWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
            }

            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;
            myRigidBody.velocity = Vector2.zero;
            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
	}
    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
