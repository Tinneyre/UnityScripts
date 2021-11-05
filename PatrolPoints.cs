using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPoints : MonoBehaviour {
    public GameObject platform;
    public float moveSpeed;
    public float selectedSpeed;
    public float timeStamp;
    public float freezeCoolDownPeriodInSeconds;
    private Transform currentPoint;
    public Transform[] points;
    public int pointSelection;
    public GameObject freezePower;
    public bool frozen;
    private int frozenControl;
    private int negativeValue;


    // Use this for initialization
    void Start()
    {

        currentPoint = points[pointSelection];
        frozen = false;
        frozenControl = -1;
        negativeValue = -1;

    }

    // Update is called once per frame
    void Update()
    {

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

        if (frozenControl == 1)
        {
            moveSpeed = 0;
        }


        if (frozenControl == -1)
        {

            moveSpeed = selectedSpeed;
        }


        /*if (timeStamp <= Time.time) {
            if (CrossPlatformInputManager.GetButtonDown("Freeze")) {
                //if (charged = false) {

                GetComponent<PlayerDash> ().enabled = true;
                timeStamp = Time.time + coolDownPeriodInSeconds;
                StartCoroutine (dashOff ());




            }*/

      /*  if (timeStamp <= Time.time)
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
}
