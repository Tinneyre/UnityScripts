using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDamage : MonoBehaviour {

    public int damageToGive;
    private int currentDamage;
    public GameObject damageBurst;
    public Transform hitPoint;
    public GameObject damageNumber;

    private PlayerStats thePS;

    void Start()
    {
        thePS = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyHealth")
        {
            currentDamage = damageToGive;

            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(currentDamage);
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
            var clone = (GameObject)Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;
            Destroy(gameObject);
        }


        
        
    }
}
