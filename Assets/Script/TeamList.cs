using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamList : MonoBehaviour
{
    public GameObject waveOne;
    public GameObject[] enemyList;
    [HideInInspector]
    public GameObject waveTwo;
    [HideInInspector]
    public GameObject waveThree;
    private int level;
    private void Start()
    { level = PlayerPrefs.GetInt("LEVEL");
        if (level == 1)
        {
            waveTwo = enemyList[0];
            waveThree = enemyList[1];
        }
        else if (level == 2)
        {
            waveTwo = enemyList[0];
            waveThree = enemyList[2];
        }
        else if (level == 3)
        {
            waveTwo = enemyList[1];
            waveThree = enemyList[0];
        }
        else if (level == 4)
        {
            waveTwo = enemyList[1];
            waveThree = enemyList[2];
        }
        else if (level == 5)
        {
            waveTwo = enemyList[2];
            waveThree = enemyList[0];
        }else if (level == 6)
        {
            waveTwo = enemyList[2];
            waveThree = enemyList[1];
        }
    }
    void levelFeatures()
    {

    }
}
