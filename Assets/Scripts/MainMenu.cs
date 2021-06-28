using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            settings.SetActive(false);
        }
    }
    public GameObject settings;

   public void StartGameButton()
    {
        SceneManager.LoadScene("Level-1-1");
    }

    public void SettingsButton()
    {
        settings.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
