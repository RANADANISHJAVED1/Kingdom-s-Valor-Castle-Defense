using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenuEnemySetting : MonoBehaviour
{
    public int firstWaveTime;
    public int secondWaveTime;
    public int thirdWaveTime;
    public int[] firstWaveEnemyNumber;
    public int[] secondWaveEnemyNumber;
    public int[] thirdWaveEnemyNumber;
    private int level;
    private void Awake()
    {
        level = PlayerPrefs.GetInt("LEVEL");
        LevelButtonClicked();
    }
    public void LevelButtonClicked()
    {
        PlayerPrefs.SetInt("firstWaveTime", firstWaveTime);
        PlayerPrefs.SetInt("secondWaveTime", secondWaveTime);
        PlayerPrefs.SetInt("thirdWaveTime", thirdWaveTime);
        PlayerPrefs.SetInt("firstWaveEnemyNumber", firstWaveEnemyNumber[level-1]);
        PlayerPrefs.SetInt("secondWaveEnemyNumber", secondWaveEnemyNumber[level- 1]);
        PlayerPrefs.SetInt("thirdWaveEnemyNumber", thirdWaveEnemyNumber[level - 1]);
       
    }

}
