using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class EnemyController : MonoBehaviour {
    public float patrolSpeed;
    public float attackSpeed;

    private Rigidbody2D myRigidbody;

    private bool moving;
    public bool patroling;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;

    public float timeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;

    public float waitToReload;
   
    public GameObject followTarget;
    private Vector3 targetPos;

    Transform player;

    private Animator anim;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;
    public bool knockFromDown;

    public GameObject target;
    public bool follow;
    public bool paused;
    private int pauseSpeed = 0;
    public int unpausedPatrolSpd;
    public int unpauseAttackSpd;
    void Start()
    {

        // timeBetweenMoveCounter = timeBetweenMove;
        //timeToMoveCounter = timeToMove;
        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);

        myRigidbody = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }

    /* void OnTriggerStay2D(Collider2D other)
     {
         if (other.gameObject.name == "Player")

         {
             follow = true;
             patroling = false;
             target = other.gameObject;
         }


     }*/


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Submit"))
                {
            paused = !paused;
        }
        if (paused)
        {
            patrolSpeed = pauseSpeed;
            attackSpeed = pauseSpeed;
        }
        else if(!paused)
        {
            patrolSpeed = unpausedPatrolSpd;
            attackSpeed = unpauseAttackSpd;
        }
            if (patroling == true)
            {
                Patrol();
            }
            if (follow == true)
            {
                FollowTarget();

            }
            if (knockbackCount < 0)
            {

                knockbackCount = 0;
            }
            if (knockbackCount <= 0)
            {
                patroling = true;
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, myRigidbody.velocity.y);

            }
            else
            {
                if (knockFromRight)
                {
                    myRigidbody.velocity = new Vector2(-knockback, 0);

                }
                if (!knockFromRight)
                {
                    myRigidbody.velocity = new Vector2(knockback, 0);

                }
                if (knockFromDown)
                {
                    myRigidbody.velocity = new Vector2(0, -knockback);


                }
                if (!knockFromDown)
                {
                    myRigidbody.velocity = new Vector2(0, knockback);

                }
                knockbackCount -= Time.deltaTime;
            }

            /* if (moving)
             {
                 timeToMoveCounter -= Time.deltaTime;
                 myRigidbody.velocity = moveDirection;

                 if (timeToMoveCounter < 0f)
                 {
                     moving = false;
                     //timeBetweenMoveCounter = timeBetweenMove;
                     timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
                 }
             }
             else
             {
                 timeBetweenMoveCounter -= Time.deltaTime;
                 myRigidbody.velocity = Vector2.zero;

                 if (timeBetweenMoveCounter < 0f)
                 {
                     moving = true;
                     // timeToMoveCounter = timeToMove;
                     timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);

                     moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
                 }
             }*/
            /* if (reloading)
             {
                 waitToReload -= Time.deltaTime;
                 if(waitToReload < 0)
                 {
                     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                     player.SetActive(true);
                 }
             }*/
        }
    
  public  void FollowTarget ()
    {
        patroling = false;
        followTarget = target.gameObject;
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);

        transform.position = Vector2.MoveTowards(transform.position, targetPos, attackSpeed * Time.deltaTime);
    }

   public  void Patrol()
    {
       follow = false;
        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = moveDirection;

            if (timeToMoveCounter < 0f)
            {
                moving = false;
                //timeBetweenMoveCounter = timeBetweenMove;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
            }
        }
        else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = Vector2.zero;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                // timeToMoveCounter = timeToMove;
                timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * patrolSpeed, Random.Range(-1f, 1f) * patrolSpeed, 0f);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        /*if (other.gameObject.name == "Player")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            reloading = true;
            player = other.gameObject;
        }*/

    }
}
