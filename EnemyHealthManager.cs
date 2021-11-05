using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

    public int enemyMaxHealth;
    public int enemyCurrentHealth;

    private PlayerStats thePlayerStats;

    public int expToGive;

    public string enemyQuestName;
    private QuestManager theQM;
    public GameObject monster;

    public GameObject[] itemSpawn;

    public Transform itemSpawnPoint;

    // Use this for initialization
    void Start()
    {

        enemyCurrentHealth = enemyMaxHealth;

        thePlayerStats = FindObjectOfType<PlayerStats>();

        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            theQM.enemyKilled = enemyQuestName;
            monster.SetActive(false);
            
            thePlayerStats.AddExperience(expToGive);
            Destroy(gameObject);
            int objectIndex = Random.Range(0, itemSpawn.Length);
            Instantiate(itemSpawn[objectIndex], itemSpawnPoint.position, itemSpawnPoint.rotation);
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        enemyCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

}