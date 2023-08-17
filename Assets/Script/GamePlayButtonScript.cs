using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayButtonScript : MonoBehaviour
{
    public GameObject pausePanal;
    public void homeBtn()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void nextBtn()
    {
        if (PlayerPrefs.GetInt("LEVEL") < 4)
        {
            PlayerPrefs.SetInt("LEVEL", PlayerPrefs.GetInt("LEVEL") + 1);
        }
        else
        {
            PlayerPrefs.SetInt("LEVEL", 1);
        }
        
        SceneManager.LoadScene("GamePlayScene");
    }
    public void replayBtn()
    {
        SceneManager.LoadScene("GamePlayScene");
    }
    public void pauseBtn()
    {
        pausePanal.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pausePanal.SetActive(false);
        
    }
}
