using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

    private bool reloading;
    private int currentDamage;
    public GameObject damageNumber;
    public int damageToGive;
    public float knockbackPower;

    private PlayerStats thePS;

    // Use this for initialization
    void Start () {
        thePS = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        /*if(other.gameObject.name == "Player")
        {
            currentDamage = damageToGive - thePS.currentDefense;
            if(currentDamage < 0)
            {
                currentDamage = 0;
            }

            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(currentDamage);
            var clone = (GameObject)Instantiate(damageNumber, other.transform.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;

            
        }*/
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            var player = other.GetComponent<PlayerController>();
            player.knockbackCount = knockbackPower;

            if(other.transform.position.x < transform.position.x)
            {
                player.knockFromRight = true;
            }
            else
            {
                player.knockFromRight = false;
            }
            if (other.transform.position.y < transform.position.y)
            {
                player.knockFromDown = true;
            }
            else
            {
                player.knockFromDown = false;
            }
            currentDamage = damageToGive - thePS.currentDefense;
            if (currentDamage < 0)
            {
                currentDamage = 0;
            }

            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(currentDamage);
            
        }
    }
}
