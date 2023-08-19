using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLevelSelection : MonoBehaviour
{
    public int level;
    public void setLevel()
    {
        PlayerPrefs.SetInt("LEVEL", level);
        SceneManager.LoadScene("GamePlayScene");
        GameObject.Find("GameController").GetComponent<SoundController>().clickedSoundPlay();
    }
}
