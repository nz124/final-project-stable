using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public bool gameOver;
    public GameObject gameOverPanel;
    public int curlevel;
    public Text ammoCount;
    public int ammoLevel;

    private void Start()
    {
        ammoCount.text = "" + ammoLevel;
        
    }
    public void UpdateAmmo(int ammo)
    {
        ammoLevel += ammo;
        ammoCount.text = "" + ammoLevel;
    }

    public void GameOver()
    {

        gameOver = true;
        gameOverPanel.SetActive(true);

    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("JordanLevel");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
