using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectedTeamFeaturesActivator : MonoBehaviour
{
    public GameObject[] teamOne;
    public GameObject[] teamTwo;
    private int teamNumber;
    private void Awake()
    {
        teamNumber = PlayerPrefs.GetInt("TeamNumber");
    }
    private void Start()
    {
        for(int i = 0; i < teamOne.Length; i++)
        {
            teamOne[i].SetActive(false);
        }
        for (int i = 0; i < teamTwo.Length; i++)
        {
            teamTwo[i].SetActive(false);
        }
        teamNumber=PlayerPrefs.GetInt("TeamNumber");
        activationFunction();
    }
    void activationFunction()
    {
        if(teamNumber == 1)
        {
            for (int i = 0; i < teamOne.Length; i++)
            {
                teamOne[i].SetActive(true);
            }
        }
        if (teamNumber == 2)
        {
            for (int i = 0; i < teamTwo.Length; i++)
            {
                teamTwo[i].SetActive(true);
            }
        }
    }
    public void ButtonMoveToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
