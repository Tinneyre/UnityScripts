using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : MonoBehaviour {

    public float playerRange;

    public GameObject enemyProjectile;

    public PlayerController player;

    public Transform launchPoint;

    public float projectileVelocity;

     private List<GameObject> Projectiles = new List<GameObject>();

    float cooldownTimer;
    public float fireDelay;

    Transform playerRotation;
    float rotSpeed = 180f;

    public bool paused;






    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerController>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonUp("Submit"))
        {
            paused = !paused;
        }

                    cooldownTimer -= Time.deltaTime;

      /*  Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));
        Debug.DrawLine(new Vector3(transform.position.x, transform.position.y - playerRange, transform.position.z), new Vector3(transform.position.x , transform.position.y + playerRange, transform.position.z));

        if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange || transform.localScale.y > 0 && player.transform.position.y < transform.position.y && player.transform.position.y > transform.position.y - playerRange)
        {
            playerRotation = player.transform;
            Vector3 dir = playerRotation.position - transform.position;
            dir.Normalize();

            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

            Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
            transform.rotation = Quaternion.RotateTowards (transform.rotation, desiredRot, rotSpeed * Time.deltaTime);

            if (cooldownTimer <= 0)
            {
                Debug.Log("EnemyPew");
                cooldownTimer = fireDelay;
                Instantiate(enemyProjectile, launchPoint.position, launchPoint.rotation);

            }
        }*/
        
      
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!paused)
            {


                playerRotation = player.transform;
                Vector3 dir = playerRotation.position - transform.position;
                dir.Normalize();

                float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

                Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);

                if (cooldownTimer <= 0)
                {
                    Debug.Log("EnemyPew");
                    cooldownTimer = fireDelay;
                    Instantiate(enemyProjectile, launchPoint.position, launchPoint.rotation);

                }
            }
        }
    }
}
