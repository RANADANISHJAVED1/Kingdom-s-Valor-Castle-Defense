using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayButtonScript : MonoBehaviour
{
    public GameObject pausePanal;
    public void homeBtn()
    {
        GameObject.Find("GameManager").GetComponent<GamePlaySceneMusicController>().touchSoundPlay();

        SceneManager.LoadScene("MainMenuScene");
    }
    public void nextBtn()
    {
        if (PlayerPrefs.GetInt("LEVEL") < 6)
        {
            PlayerPrefs.SetInt("LEVEL", PlayerPrefs.GetInt("LEVEL") + 1);
        }
        else
        {
            PlayerPrefs.SetInt("LEVEL", 1);
        }
        GameObject.Find("GameManager").GetComponent<GamePlaySceneMusicController>().touchSoundPlay();
        SceneManager.LoadScene("GamePlayScene");
    }
    public void replayBtn()
    {
        GameObject.Find("GameManager").GetComponent<GamePlaySceneMusicController>().touchSoundPlay();
        SceneManager.LoadScene("GamePlayScene");
    }
    public void pauseBtn()
    {
        GameObject.Find("GameManager").GetComponent<GamePlaySceneMusicController>().touchSoundPlay();
        pausePanal.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        GameObject.Find("GameManager").GetComponent<GamePlaySceneMusicController>().touchSoundPlay();
        Time.timeScale = 1;
        pausePanal.SetActive(false);
        
    }
}
