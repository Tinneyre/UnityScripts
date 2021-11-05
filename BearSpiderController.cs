using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSpiderController : MonoBehaviour {

    public GameObject platform;
    public float moveSpeed;
    public float selectedSpeed;
    public float attackSpeed;
    public float patrolSpeed;
    public float timeStamp;
    public float freezeCoolDownPeriodInSeconds;
    private Transform currentPoint;
    public Transform[] points;
    public int pointSelection;
    private Transform currentAttackPoint;
    public Transform[] attackPoints;
    public int attackPointSelection;
    public GameObject freezePower;
    public bool frozen;
  
    private int negativeValue;

    public float attackTimer;
    public float attackTime;

    public float patrolTimer;
    public float patrolTime;

    public bool paused;
   
   



    // Use this for initialization
    void Start()
    {
        currentAttackPoint = attackPoints[attackPointSelection];
        currentPoint = points[pointSelection];
        frozen = false;
        
        negativeValue = -1;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonUp("Submit"))
        {
            paused = !paused;
        }

        if(paused)
        {
           attackSpeed = 0;
            patrolSpeed = 0;

        }
        else if (!paused)
        {
            attackSpeed = selectedSpeed;
            patrolSpeed = selectedSpeed;
        }



        /*if (frozen)
        {
            moveSpeed = 0;
        }


        else if (!frozen )
        {

            moveSpeed = selectedSpeed;
        }*/

        if(attackTimer > 0)
        {
            moveSpeed = attackSpeed;
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, currentAttackPoint.position, Time.deltaTime * moveSpeed);
            attackTimer -= Time.deltaTime;
            if (platform.transform.position == currentAttackPoint.position)
            {

                attackPointSelection++;

                if (attackPointSelection == attackPoints.Length)
                {
                    attackPointSelection = 0;
                }



                currentAttackPoint = attackPoints[attackPointSelection];
              
            }
            else if (attackTimer <= 0)
            {
                ResetPatrolTimer();
            }
            
        }
       if (patrolTimer > 0 )
        {
            moveSpeed = patrolSpeed;
            patrolTimer -= Time.deltaTime;
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);
            if (platform.transform.position == currentPoint.position)
            {

                pointSelection++;

                if (pointSelection == points.Length)
                {
                    pointSelection = 0;
                }



                currentPoint = points[pointSelection];
              
            }
            else if (patrolTimer <= 0)
            {
                ResetAttackTimer();
            }
        }
       


        /* if (timeStamp <= Time.time)
         {
             if (CrossPlatformInputManager.GetButtonDown("Freeze"))
             {
                 freezePower = GameObject.FindGameObjectWithTag("FreezePower");
                 {
                     if (freezePower.activeSelf == true)
                     {
                         {
                             frozenControl = frozenControl * negativeValue;
                             timeStamp = Time.time + freezeCoolDownPeriodInSeconds;
                         }

                     }
                 }
             }
         }*/

    }

    void ResetAttackTimer()
    {
        attackTimer = attackTime;
    }
    void ResetPatrolTimer()
    {
        patrolTimer = patrolTime;
    }
}
