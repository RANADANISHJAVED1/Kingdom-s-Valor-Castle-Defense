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
    private int teamNumberAsEnemy;
    public int loop;
    float time;
    int zPositionNotRandomForFirst = 1;
    int zPositionNotRandomForSecond = 1;
    int zPositionNotRandomForThird = 1;
    private float secWaitTime=0;

    private void Start()
    {
        zPositionNotRandomForFirst = 1;
        zPositionNotRandomForSecond = 2;
        zPositionNotRandomForThird = 3;
        teamList = this.gameObject.GetComponent<TeamList>();
        teamNumberAsEnemy = PlayerPrefs.GetInt("TeamNumber");
        firstWaveTime = PlayerPrefs.GetInt("firstWaveTime");
        secondWaveTime = PlayerPrefs.GetInt("secondWaveTime");
        thirdWaveTime = PlayerPrefs.GetInt("thirdWaveTime");
        firstWaveEnemyNumbers = PlayerPrefs.GetInt("firstWaveEnemyNumber");
        secondWaveEnemyNumbers = PlayerPrefs.GetInt("secondWaveEnemyNumber");
        thirdWaveEnemyNumbers = PlayerPrefs.GetInt("thirdWaveEnemyNumber");
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
            secWaitTime = secWaitTime + 2.2f;   
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
            secWaitTime = 0;
        }
        else if (time <= 0 && firstWaveTime <= 0 && secondWaveTime <= 0 && thirdWaveTime > 0 && loop == 0)
        {
            time = thirdWaveTime;
            loop = thirdWaveEnemyNumbers;
            secWaitTime = 0;
        }
    }
    IEnumerator randomSpawnEnemy()
    {
        
        yield return new WaitForSeconds(secWaitTime);
        if (teamNumberAsEnemy == 1)
        {
            if (firstWaveTime < 0 && secondWaveTime > 0)
            {
                if (zPositionNotRandomForFirst <= 5)
                {
                    var obj = Instantiate(teamList.TeamOneWaveOne, new Vector3(12, 0, zPositionNotRandomForFirst), teamList.TeamOneWaveOne.transform.rotation);
                    obj.transform.parent = EnemyListFatherObj.transform;
                    zPositionNotRandomForFirst = numberSwitch(zPositionNotRandomForFirst);
                }
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime > 0)
            {
                if (zPositionNotRandomForSecond <= 5)
                {
                    var obj = Instantiate(teamList.TeamOneWaveTwo, new Vector3(8, 0, zPositionNotRandomForSecond), teamList.TeamOneWaveTwo.transform.rotation);
                    obj.transform.parent = EnemyListFatherObj.transform;
                    zPositionNotRandomForSecond = numberSwitch(zPositionNotRandomForSecond);
                }
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime < 0)
            {
                if (zPositionNotRandomForThird <= 5)
                {
                    var obj = Instantiate(teamList.TeamOneWaveThree, new Vector3(8, 0, zPositionNotRandomForThird), teamList.TeamOneWaveThree.transform.rotation);
                    obj.transform.parent = EnemyListFatherObj.transform;
                    zPositionNotRandomForThird = numberSwitch(zPositionNotRandomForThird);
                }
            }
        }
        else if (teamNumberAsEnemy == 2)
        {
            if (firstWaveTime < 0 && secondWaveTime > 0)
            {
                if (zPositionNotRandomForFirst <= 5)
                {
                    var obj = Instantiate(teamList.TeamTwoWaveOne, new Vector3(15, 0, zPositionNotRandomForFirst), teamList.TeamTwoWaveOne.transform.rotation);
                    obj.transform.parent = EnemyListFatherObj.transform;
                    zPositionNotRandomForFirst = numberSwitch(zPositionNotRandomForFirst);
                    
                }
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime > 0)
            {
                if (zPositionNotRandomForSecond <= 5)
                {
                    var obj = Instantiate(teamList.TeamTwoWaveTwo, new Vector3(8, 0, zPositionNotRandomForSecond), teamList.TeamTwoWaveTwo.transform.rotation);
                    obj.transform.parent = EnemyListFatherObj.transform;
                    zPositionNotRandomForSecond = numberSwitch(zPositionNotRandomForSecond);
                    
                }
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime < 0)
            {
                if (zPositionNotRandomForThird <= 5)
                {
                    var obj = Instantiate(teamList.TeamTwoWaveThree, new Vector3(8, 0, zPositionNotRandomForThird), teamList.TeamTwoWaveThree.transform.rotation);
                    obj.transform.parent = EnemyListFatherObj.transform;
                    zPositionNotRandomForThird = numberSwitch(zPositionNotRandomForThird);
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
