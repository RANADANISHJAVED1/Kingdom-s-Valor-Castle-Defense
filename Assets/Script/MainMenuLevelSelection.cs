using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuLevelSelection : MonoBehaviour
{
    public int firstWaveTime;
    public int secondWaveTime;
    public int thirdWaveTime;
    public int firstWaveEnemyNumber;
    public int secondWaveEnemyNumber;
    public int thirdWaveEnemyNumber;
    public void setValues()
    {
        PlayerPrefs.SetInt("firstWaveTime", firstWaveTime);
        PlayerPrefs.SetInt("secondWaveTime", secondWaveTime);
        PlayerPrefs.SetInt("thirdWaveTime", thirdWaveTime);
        PlayerPrefs.SetInt("firstWaveEnemyNumber", firstWaveEnemyNumber);
        PlayerPrefs.SetInt("secondWaveEnemyNumber", secondWaveEnemyNumber);
        PlayerPrefs.SetInt("thirdWaveEnemyNumber", thirdWaveEnemyNumber);
    }
}
