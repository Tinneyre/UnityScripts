using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider healthBar;
    public Text HPText;
    public PlayerHealthManager playerHealth;

    public Slider magicBar;
    public Text MPText;
    //public MagicManager magicMan;

    public Text levelText;
    public Text keysText;
    public Text moneyText;

    public Projectile projectile;
    public Text ammoCount;

    private MoneyManager monMan;

    private PlayerStats thePS;
  
    private static bool UIExists;

    public GameObject fireMagic;
    public GameObject earthMagic;
    public GameObject airMagic;
    public GameObject waterMagic;

    public MagicManager magicMan;

	// Use this for initialization
	void Start () {
        if (!UIExists)
        {
            UIExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        thePS = FindObjectOfType<PlayerStats>();
        projectile = FindObjectOfType<Projectile>();
        monMan = FindObjectOfType<MoneyManager>();
        magicMan = FindObjectOfType<MagicManager>();
    }
	
	// Update is called once per frame
	void Update () {

        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        magicBar.maxValue = magicMan.maxMagic;
        magicBar.value = magicMan.currentMagic;
        MPText.text = "MP: " + magicMan.currentMagic + "/" + magicMan.maxMagic;
        HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
        levelText.text = "Level: " + thePS.currentLevel;
        ammoCount.text = "Arrow: " + projectile.ammoCurrentCount + "/" + projectile.ammoMaxCount;
        keysText.text = "Keys: " + thePS.keys;
        moneyText.text = "Gold: " + monMan.moneyCount;
        
        if(magicMan.fireMagicActive == true)
        {
            fireMagic.SetActive(true);
        }
        else if (magicMan.fireMagicActive == false)
        {
            fireMagic.SetActive(false);
        }
        if (magicMan.earthMagicActive == true)
        {
            earthMagic.SetActive(true);
        }
        else if (magicMan.earthMagicActive == false)
        {
            earthMagic.SetActive(false);
        }
        if (magicMan.airMagicActive == true)
        {
            airMagic.SetActive(true);
        }
        else if (magicMan.airMagicActive == false)
        {
            airMagic.SetActive(false);
        }
        if (magicMan.waterMagicActive == true)
        {
            waterMagic.SetActive(true);
        }
        else if (magicMan.waterMagicActive == false)
        {
            waterMagic.SetActive(false);
        }
    }
}
