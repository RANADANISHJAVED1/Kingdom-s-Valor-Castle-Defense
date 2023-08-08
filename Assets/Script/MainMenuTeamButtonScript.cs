using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTeamButtonScript : MonoBehaviour
{
    public int teamNumber;
    public void teamSelection()
    {
        PlayerPrefs.SetInt("TeamNumber", teamNumber);
        SceneManager.LoadScene("GamePlayScene");
    }
}
