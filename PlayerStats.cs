using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;

    public int currentExp;

    public int[] toLevelUp;

    public int[] HPLevels;
    public int[] attackLevels;
    public int[] defenseLevels;

    public int currentHP;
    public int currentAttack;
    public int currentDefense;

    public bool keyPickup = false;
    public int keys;
    private int keyNumber = 1;

    public GameObject lvlUp;

    private PlayerHealthManager playerHealth;
	// Use this for initialization
	void Start () {
        currentHP = HPLevels[1];
        currentAttack = attackLevels[1];
        currentDefense = defenseLevels[1];
        playerHealth = FindObjectOfType<PlayerHealthManager>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(currentExp >= toLevelUp[currentLevel])
        {
            // currentLevel++;

            LevelUp();
        }

        if(keys > 0)
        {
            keyPickup = true;
        }
        else if(keys == 0)
        {
            keyPickup = false;
        }

	}
    public void LevelUp()
    {
        currentLevel++;
        currentHP = HPLevels[currentLevel];

        playerHealth.playerMaxHealth = currentHP;
        playerHealth.playerCurrentHealth += currentHP - HPLevels[currentLevel - 1];

        currentAttack = attackLevels[currentLevel];
        currentDefense = defenseLevels[currentLevel];

       Instantiate(lvlUp, transform.position, Quaternion.Euler(Vector3.zero));
        
    }
    
    public void AddExperience(int experienceToAdd)
    {
        currentExp += experienceToAdd;
    }

   /* void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Key")
        {
            GetKey();
            
        }
    }*/
    public void UseKey()
    {
        keys -= keyNumber;
    }
    public void GetKey()
    {
        keys += keyNumber;
        Debug.Log("Key Get");
    }
}
