using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectedTeamFeaturesActivator : MonoBehaviour
{
    public GameObject[] teamOne;
    public GameObject[] teamTwo;
    public int currency;
    private int teamNumber;
    public TextMeshProUGUI currencyText;
    private void Awake()
    {
        currency = 150;
        currencyText.text = currency.ToString();
        teamNumber = PlayerPrefs.GetInt("TeamNumber");
    }
    private void Start()
    {
        for (int i = 0; i < teamOne.Length; i++)
        {
            teamOne[i].SetActive(false);
        }
        for (int i = 0; i < teamTwo.Length; i++)
        {
            teamTwo[i].SetActive(false);
        }
        teamNumber = PlayerPrefs.GetInt("TeamNumber");
        activationFunction();
    }
    void activationFunction()
    {
        /*if (teamNumber == 1)
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
        }*/
        checkButtonActivation();
    }
    public void checkButtonActivation()
    {
        if (currency >= 25 && currency <30)
        {
            if (teamNumber == 1)
            {
                teamOne[0].SetActive(true);
                teamOne[1].SetActive(false);
                teamOne[2].SetActive(false);

            }
            else if (teamNumber == 2)
            {
                teamTwo[0].SetActive(true);
                teamTwo[1].SetActive(false);
                teamTwo[2].SetActive(false);

            }
        }
        else if (currency >= 30 && currency < 50)
        {
            if (teamNumber == 1)
            {
                teamOne[0].SetActive(true);
                teamOne[1].SetActive(true);
                teamOne[2].SetActive(false);

            }
            else if (teamNumber == 2)
            {
                teamTwo[0].SetActive(true);
                teamTwo[1].SetActive(true);
                teamTwo[2].SetActive(false);
            }
        }
        else if (currency >= 50)
        {
            if (teamNumber == 1)
            {
                teamOne[0].SetActive(true);
                teamOne[1].SetActive(true);
                teamOne[2].SetActive(true);

            }
            else if (teamNumber == 2)
            {
                teamTwo[0].SetActive(true);
                teamTwo[1].SetActive(true);
                teamTwo[2].SetActive(true);
            }
        }
        else if (currency < 25)
        {
            if (teamNumber == 1)
            {
                teamOne[0].SetActive(false);
                teamOne[1].SetActive(false);
                teamOne[2].SetActive(false);

            }
            else if (teamNumber == 2)
            {
                teamTwo[0].SetActive(false);
                teamTwo[1].SetActive(false);
                teamTwo[2].SetActive(false);
            }
        }
        currencyText.text = currency.ToString();
    }
    public void ButtonMoveToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void currencyDecrese(int n)
    {
        currency = currency + n;
    }
}
