using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

    private bool flashActive;
    public float flashLength;
    private float flashCounter;

    private SpriteRenderer playerSprite;

    private SFXManager sfxMan;

	private PlayerStats thePS;

	// Use this for initialization
	void Start () {

        playerCurrentHealth = playerMaxHealth;

        playerSprite = GetComponent<SpriteRenderer>();

        sfxMan = FindObjectOfType<SFXManager>();

		thePS = FindObjectOfType<PlayerStats> ();
    }
	
	// Update is called once per frame
	void Update () {
	    if(playerCurrentHealth <= 0)
        {
            sfxMan.playerDead.Play();

            // gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            playerCurrentHealth = playerMaxHealth;
        }
        if(flashActive)
        {
			thePS.currentDefense = 1000;
            if(flashCounter > flashLength * .66f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.g, 0f);
            }
            else if (flashCounter > flashLength * .33f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.g, 1f);
            }
            else if(flashCounter > 0f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.g, 0f);
            }

            if(flashCounter < 0)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.g, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
		else if(!flashActive)
		{
			thePS.currentDefense = 0;
		}
        if(playerCurrentHealth > playerMaxHealth)
        {
            playerCurrentHealth = playerMaxHealth;
        }
	}

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;

        flashActive = true;
        flashCounter = flashLength;

        sfxMan.playerHurt.Play();
    }

    public void HealPlayer(int damageToGive)
    {
        playerCurrentHealth += damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }


}
