using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private TeamList teamList;
    public GameObject EnemyListFatherObj;
    private float firstWaveTime;
    private float secondWaveTime;
    private float thirdWaveTime;
    private int firstWaveEnemyNumbers;
    private int secondWaveEnemyNumbers;
    private int thirdWaveEnemyNumbers;
    private int teamNumberAsEnemy;
    int loop;
    float time;
    private void Start()
    {
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
            randomSpawnEnemy();
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
        if(time <= 0 && firstWaveTime > 0  && loop == 0 )
        {
            time = firstWaveTime;
            loop = firstWaveEnemyNumbers;
        }
        if (time <= 0 && firstWaveTime <= 0 && secondWaveTime > 0 && loop == 0)
        {
            time = secondWaveTime;
            loop = secondWaveEnemyNumbers;
        }
        else if (time <= 0 && firstWaveTime <= 0 && secondWaveTime <= 0 && thirdWaveTime > 0 && loop == 0)
        {
            time = thirdWaveTime;
            loop = thirdWaveEnemyNumbers;
        }
    }
    private void randomSpawnEnemy()
    {
        int xPositionRandom = Random.Range(11, 20);
        int zPositionRandom = Random.Range(1, 6);
        if (teamNumberAsEnemy == 1)
        {
            if(firstWaveTime<0 && secondWaveTime > 0)
            {
                var obj = Instantiate(teamList.TeamOneWaveOne, new Vector3(xPositionRandom, 0, zPositionRandom), teamList.TeamOneWaveOne.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime > 0)
            {
                var obj = Instantiate(teamList.TeamOneWaveTwo, new Vector3(xPositionRandom, 0, zPositionRandom), teamList.TeamOneWaveTwo.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime < 0)
            {
                var obj = Instantiate(teamList.TeamOneWaveThree, new Vector3(xPositionRandom, 0, zPositionRandom), teamList.TeamOneWaveThree.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
            }
        }
        else if (teamNumberAsEnemy == 2)
        {
            if (firstWaveTime < 0 && secondWaveTime > 0)
            {
                var obj = Instantiate(teamList.TeamTwoWaveOne, new Vector3(xPositionRandom, 0, zPositionRandom), teamList.TeamTwoWaveOne.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime > 0)
            {
                var obj = Instantiate(teamList.TeamTwoWaveTwo, new Vector3(xPositionRandom, 0, zPositionRandom), teamList.TeamTwoWaveTwo.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
            }
            else if (firstWaveTime < 0 && secondWaveTime < 0 && thirdWaveTime < 0)
            {
                var obj = Instantiate(teamList.TeamTwoWaveThree, new Vector3(xPositionRandom, 0, zPositionRandom), teamList.TeamTwoWaveThree.transform.rotation);
                obj.transform.parent = EnemyListFatherObj.transform;
            }
        }
    }
}
