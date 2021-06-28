using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public static GameOver instance;

    private void Awake()
    {
        instance = this;
    }

    public void WhenPlayerDeath()
    {
        if (CurrentLevelManager.instance.isPlayerInLevel)
        {
            SaveSystem.instance.RejectObjects();

        }
            gameOverUI.SetActive(true);
        
    }

    public void RetryButton()
    {
        Inventory.instance.removeCoins(CurrentLevelManager.instance.coinsPickCount);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
        PlayerHealth.instance.Respawn();
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        SaveSystem.instance.RejectObjects();

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
