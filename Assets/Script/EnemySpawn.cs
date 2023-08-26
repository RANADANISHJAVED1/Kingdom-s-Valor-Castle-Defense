using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private TeamList teamList;
    public GameObject EnemyListFatherObj;
    public float firstWaveTime;
    public float secondWaveTime;
    public float thirdWaveTime;
    private int firstWaveEnemyNumbers;
    private int secondWaveEnemyNumbers;
    private int thirdWaveEnemyNumbers;
    public int loop;
    float time;
    int zPositionNotRandomForFirst;
    int zPositionNotRandomForSecond;
    int zPositionNotRandomForThird;
    float unRandomX;
    float randomPositonSecondX;
    private int loopChecker;
    private float secWaitTime = 0;
    private float TimeOfFirstWaveDefiner = 5;
    private int thirdWaveChecker;
    private int thirdWaveInnerIncrementator;
    private int loopseceondxpositionrandom;

    private void Start()
    {
        thirdWaveInnerIncrementator = 0;
        zPositionNotRandomForFirst = 1;
        zPositionNotRandomForSecond = 2;
        zPositionNotRandomForThird = 3;
        teamList = this.gameObject.GetComponent<TeamList>();
        firstWaveTime = PlayerPrefs.GetInt("firstWaveTime");
        secondWaveTime = PlayerPrefs.GetInt("secondWaveTime");
        thirdWaveTime = PlayerPrefs.GetInt("thirdWaveTime");
        firstWaveEnemyNumbers = PlayerPrefs.GetInt("firstWaveEnemyNumber");
        secondWaveEnemyNumbers = PlayerPrefs.GetInt("secondWaveEnemyNumber");
        thirdWaveEnemyNumbers = PlayerPrefs.GetInt("thirdWaveEnemyNumber");
        thirdWaveChecker = thirdWaveEnemyNumbers;
    }
    private void Update()
    {
        waveTimeAndLoopChanger();
        waveTimeUpdater();
        randomSpawnEnemyLoop();
    }
    private void randomSpawnEnemyLoop()
    {
        for (; loop > 0 && time <= 0; loop--)
        {
            StartCoroutine(randomSpawnEnemy());
            if (firstWaveTime <= 0 && secondWaveTime > 0 && thirdWaveTime > 0)
            {
                secWaitTime = 0;
            }
            else if(firstWaveTime<=0 && secondWaveTime<=0 && thirdWaveTime > 0)
            {
                secWaitTime = secWaitTime + 2.2f;
            }
            else if (firstWaveTime<=0 && secondWaveTime<= 0 && thirdWaveTime <= 0)
            {
                secWaitTime = secWaitTime + 0.2f;
            }
        }
    }
    private void waveTimeUpdater()
    {
        if (time > 0 && firstWaveTime > 0)
        {
            time -= Time.deltaTime;
            firstWaveTime -= Time.deltaTime;
        }
        else if (time > 0 && firstWaveTime <= 0 && secondWaveTime > 0)
        {
            time -= Time.deltaTime;
            secondWaveTime -= Time.deltaTime;
        }
        else if (time > 0 && firstWaveTime <= 0 && secondWaveTime <= 0 && thirdWaveTime > 0)
        {
            time -= Time.deltaTime;
            thirdWaveTime -= Time.deltaTime;
        }
    }
    private void waveTimeAndLoopChanger()
    {
        if (time <= 0 && firstWaveTime > 0 && loop == 0)
        {
            time = firstWaveTime;
            loop = firstWaveEnemyNumbers;
            secWaitTime = 0;
        }
        if (time <= 0 && firstWaveTime <= 0 && secondWaveTime > 0 && loop == 0)
        {
            time = secondWaveTime;
            loop = secondWaveEnemyNumbers;
            loopseceondxpositionrandom = loop;
            secWaitTime = 0;
        }
        else if (time <= 0 && firstWaveTime <= 0 && secondWaveTime <= 0 && thirdWaveTime > 0 && loop == 0)
        {
            time = thirdWaveTime;
            loop = thirdWaveEnemyNumbers;
            loopChecker = loop;
            secWaitTime = 0;
        }
    }
    IEnumerator randomSpawnEnemy()
    {

        yield return new WaitForSeconds(secWaitTime);

        if (firstWaveTime < 0 && secondWaveTime > 0)
        {
            if (zPositionNotRandomForFirst <= 5)
            {
                var obj = Instantiate(teamList.waveOne, new Vector3(10, 0, zPositionNotRandomForFirst), teamList.waveOne.transform.rotation);
                obj.gameObject.GetComponent<MovementOfThrowtwo>().timeOfCoritine = TimeOfFirstWaveDefiner;
                obj.gameObject.GetComponent<MovementOfThrowtwo>().timeSet = true;
                obj.transform.parent = EnemyListFatherObj.transform;
                zPositionNotRandomForFirst = numberSwitch(zPositionNotRandomForFirst);
                TimeOfFirstWaveDefiner = TimeOfFirstWaveDefiner + 2.2f;
            }
        }
        else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime > 0)
        {
            
            if (zPositionNotRandomForSecond <= 5)
            {
               
                if (loopseceondxpositionrandom > 10)
                {
                    randomPositonSecondX = 6;
                    loopseceondxpositionrandom--;
                }
                else if (loopseceondxpositionrandom <=10 && loopseceondxpositionrandom > 5)
                {
                    randomPositonSecondX = 7;
                    loopseceondxpositionrandom--;
                }
                else if (loopseceondxpositionrandom <=5 && loopseceondxpositionrandom>0)
                {
                    randomPositonSecondX = 8;
                    loopseceondxpositionrandom--;
                }
                var obj = Instantiate(teamList.waveTwo, new Vector3(randomPositonSecondX, 0, zPositionNotRandomForSecond), teamList.waveTwo.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
                zPositionNotRandomForSecond = numberSwitch(zPositionNotRandomForSecond);
            }
        }
        else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime < 0)
        {
            if (zPositionNotRandomForThird <= 5)
            {
                
                if (loopChecker > 10)
                {
                    unRandomX = 6;
                    loopChecker--;
                }
                else if(loopChecker>5 && loopChecker <= 10)
                {
                    unRandomX = 7;
                    loopChecker--;
                }
                else if (loopChecker >= 0 && loopChecker<= 5)
                {
                    unRandomX = 8;
                    loopChecker--;
                }
                var obj = Instantiate(teamList.waveThree, new Vector3(unRandomX, 0, zPositionNotRandomForThird), teamList.waveThree.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
                zPositionNotRandomForThird = numberSwitch(zPositionNotRandomForThird);
                thirdWaveInnerIncrementator++;
                if (thirdWaveInnerIncrementator == thirdWaveChecker)
                {
                    GameObject.Find("EnemyListSpawned").GetComponent<WinLogic>().complete = true;
                }
            }
        }

    }
    int numberSwitch(int n)
    {
        if (n == 1)
        {
            n = 4;
        }
        else if (n == 4)
        {
            n = 2;
        }
        else if (n == 2)
        {
            n = 5;
        }
        else if (n == 5)
        {
            n = 3;
        }
        else if (n == 3)
        {
            n = 1;
        }
        return n;
    }
}
