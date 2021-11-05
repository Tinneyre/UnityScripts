using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour {

    public EventSystem eS;
    private GameObject storedSelected;
    public GameObject firstObject;

    void Start()
    {
        storedSelected = eS.firstSelectedGameObject;
    }

    void Update()
    {
        if(eS.currentSelectedGameObject != storedSelected)
        {
            if(eS.currentSelectedGameObject == null)
            {
                eS.SetSelectedGameObject(storedSelected);
            }
            else
            {
                storedSelected = eS.currentSelectedGameObject;
            }
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void SwitchMenu()
    {
        eS.SetSelectedGameObject(firstObject, null);
    }
}
