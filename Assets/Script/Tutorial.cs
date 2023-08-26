using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject toturialPanal;
    public GameObject[] cardsBtns;
    public GameObject cancleBtn;
    public GameObject WaveBar;
    public GameObject coinsIncrement;
    public GameObject coinIndecator;
    public GameObject pauseBtn;
    public GameObject cardsTxt;
    public GameObject cancleTxt;
    public GameObject waveBarTxt;
    public GameObject CoinIncrementTxt;
    public GameObject coinIndecatorTxt;
    public GameObject topPanal;
    public GameObject ourCastlePanal;
    public GameObject[] ourCastleTreePoints;
    public GameObject enemyCastlePanal;
    public GameObject[] enemyCastleTreePoints;
    int i = 0;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("TOTURIAL"))
        {
            StartCoroutine(Touturial());
        }
        else
        {
            toturialPanal.SetActive(false);
        }
    }
    IEnumerator Touturial()
    {
        yield return new WaitForSeconds(3.8f);
        cancleBtn.SetActive(false);
        pauseBtn.SetActive(false);
        WaveBar.SetActive(false);
        coinsIncrement.SetActive(false);
        coinIndecator.SetActive(false);
        topPanal.SetActive(true);
        cardsTxt.SetActive(true);
        Time.timeScale = 0;
    }
    public void nextbtnfirstPanalClicked()
    {
        if (i == 0)
        {
            cardsBtns[0].SetActive(false);
            cardsBtns[1].SetActive(false);
            cardsBtns[2].SetActive(false);
            cancleBtn.SetActive(true);
            cardsTxt.SetActive(false);
            cancleTxt.SetActive(true);
            i++;
        }
        else if (i == 1)
        {
            cancleBtn.SetActive(false);
            cancleTxt.SetActive(false);
            WaveBar.SetActive(true);
            waveBarTxt.SetActive(true);
            i++;
        }
        else if (i == 2)
        {
            WaveBar.SetActive(false);
            waveBarTxt.SetActive(false);
            coinsIncrement.SetActive(true);
            CoinIncrementTxt.SetActive(true);
            i++;
        }
        else if (i == 3)
        {
            coinsIncrement.SetActive(false);
            CoinIncrementTxt.SetActive(false);
            coinIndecator.SetActive(true);
            coinIndecatorTxt.SetActive(true);
            i++;
        }
        else if (i == 4)
        {
            coinIndecator.SetActive(false);
            coinIndecatorTxt.SetActive(false);
            topPanal.SetActive(false);
            ourCastlePanal.SetActive(true);
            ourCastleTreePoints[0].SetActive(true);
            i=0;
        }
    }
    public void nextbtnSecondPanalClicked()
    {
        if (i == 0)
        {
            ourCastleTreePoints[0].SetActive(false);
            ourCastleTreePoints[1].SetActive(true);
            i++;
        }
        else if (i == 1)
        {
            ourCastleTreePoints[1].SetActive(false);
            ourCastleTreePoints[2].SetActive(true);
            i++;
        }
        else if (i == 2)
        {
            ourCastleTreePoints[2].SetActive(false);
            ourCastlePanal.SetActive(false);
            enemyCastlePanal.SetActive(true);
            enemyCastleTreePoints[0].SetActive(true);
            i=0;
        }
    }
    public void nextbtnThirdPanalClicked()
    {
        if (i == 0)
        {
            enemyCastleTreePoints[0].SetActive(false);
            enemyCastleTreePoints[1].SetActive(true);
            i++;
        }
        else if (i == 1)
        {
            enemyCastleTreePoints[1].SetActive(false);
            enemyCastleTreePoints[2].SetActive(true);
            i++;
        }
        else if (i == 2)
        {
            enemyCastleTreePoints[2].SetActive(false);
            enemyCastlePanal.SetActive(false);
            Time.timeScale = 1;
            cardsBtns[0].SetActive(true);
            cardsBtns[1].SetActive(true);
            cardsBtns[2].SetActive(true);
            WaveBar.SetActive(true);
            coinsIncrement.SetActive(true);
            coinIndecator.SetActive(true);
            pauseBtn.SetActive(true);
            PlayerPrefs.SetInt("TOTURIAL", 1);
        }
    }
}
