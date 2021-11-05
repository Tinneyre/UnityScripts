using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;
    private int currentDamage;
    public GameObject damageBurst;
    public Transform hitPoint;
    public GameObject damageNumber;
    public float knockbackPower;

    private PlayerStats thePS;

	void Start () {
        thePS = FindObjectOfType<PlayerStats>();

	}
	
	// Update is called once per frame
	void Update () {
       

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            

           
          var enemy = other.GetComponent<EnemyController>();
            enemy.knockbackCount = knockbackPower;

            if (other.transform.position.x < transform.position.x)
            {
                enemy.knockFromRight = true;
            }
            else
            {
                enemy.knockFromRight = false;
            }
            if (other.transform.position.y < transform.position.y)
            {
                enemy.knockFromDown = true;
            }
            else
            {
                enemy.knockFromDown = false;
            }
                }
                               if (other.gameObject.tag == "Wolf")
                                 {



                                var enemy = other.GetComponent<EnemyController>();
                                enemy.knockbackCount = knockbackPower;

                                if (other.transform.position.x < transform.position.x)
                                {
                                    enemy.knockFromRight = true;
                                }
                                else
                                {
                                    enemy.knockFromRight = false;
                                }
                                if (other.transform.position.y < transform.position.y)
                                {
                                    enemy.knockFromDown = true;
                                }
                                else
                                {
                                    enemy.knockFromDown = false;
                                }
                            }
        if (other.gameObject.tag == "Web")
        {
            currentDamage = damageToGive + thePS.currentAttack;

            other.gameObject.GetComponent<WebZone>().HurtEnemy(currentDamage);
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
            var clone = (GameObject)Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;
        }
        if(other.gameObject.tag == "EnemyHealth")
        {
            currentDamage = damageToGive + thePS.currentAttack;
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(currentDamage);
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
            var clone = (GameObject)Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;
        }
    }
}
