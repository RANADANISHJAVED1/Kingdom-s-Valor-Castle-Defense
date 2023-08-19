using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectedTeamFeaturesActivator : MonoBehaviour
{
    public GameObject[] ButtonL1;
    public GameObject[] ButtonL2;
    public GameObject[] ButtonL3;
    public int[] currencyList;
    private  GameObject buttonOne;
    private  GameObject buttonTwo;
    private  GameObject buttonThree;
    public int currency;
    public TextMeshProUGUI currencyText;
    public int level;
    public TextMeshProUGUI levelTxt;
    private void Awake()
    {
        level = PlayerPrefs.GetInt("LEVEL");
        currency = currencyList[level-1];
        currencyText.text = currency.ToString();
        levelTxt.text = "level : " + level;
    }
    private void Start()
    {
        for (int i = 0; i < ButtonL1.Length; i++)
        {
            ButtonL1[i].SetActive(false);
        }
        for (int i = 0; i < ButtonL2.Length; i++)
        {
            ButtonL2[i].SetActive(false);
        }
        for (int i = 0; i < ButtonL3.Length; i++)
        {
            ButtonL3[i].SetActive(false);
        }
        levelFeatures();
        checkButtonActivation();
    }
    void levelFeatures()
    {
        if (level == 1)
        {
            buttonOne = ButtonL1[0];
            buttonTwo = ButtonL2[0];
            buttonThree = ButtonL3[1];
        }
        else if (level == 2)
        {
            buttonOne = ButtonL1[0];
            buttonTwo = ButtonL2[0];
            buttonThree = ButtonL3[1];
        }
        else if (level == 3)
        {
            buttonOne = ButtonL1[1];
            buttonTwo = ButtonL2[0];
            buttonThree = ButtonL3[1];
        }
        else if (level == 4)
        {
            buttonOne = ButtonL1[1];
            buttonTwo = ButtonL2[0];
            buttonThree = ButtonL3[2];
        }
        else if (level == 5)
        {
            buttonOne = ButtonL1[0];
            buttonTwo = ButtonL2[0];
            buttonThree = ButtonL3[1];
        }
        else if (level == 6)
        {
            buttonOne = ButtonL1[1];
            buttonTwo = ButtonL2[0];
            buttonThree = ButtonL3[2];
        }
    }
    public void checkButtonActivation()
    {
        if (currency >= 25 && currency <30)
        {
            buttonOne.SetActive(true);
            buttonTwo.SetActive(false);
            buttonThree.SetActive(false);
        }
        else if (currency >= 30 && currency < 50)
        {
            if(level !=4 && level != 6)
            {
                buttonOne.SetActive(true);
                buttonTwo.SetActive(true);
                buttonThree.SetActive(false);
            }
        }
        else if (currency >= 50)
        {
            buttonOne.SetActive(true);
            buttonTwo.SetActive(true);
            buttonThree.SetActive(true);
        }
        else if (currency < 25)
        {
            buttonOne.SetActive(false);
            buttonTwo.SetActive(false);
            buttonThree.SetActive(false);
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
        checkButtonActivation();
    }
}
