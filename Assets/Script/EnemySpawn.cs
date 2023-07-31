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
    public int firstWaveEnemyNumbers;
    public int secondWaveEnemyNumbers;
    public int thirdWaveEnemyNumbers;
    public int teamNumberAsEnemy;
    int loop;
    float time;
    private void Start()
    {
        teamList = this.gameObject.GetComponent<TeamList>();
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
        if(teamNumberAsEnemy == 1)
        {
            int randomEnemy = Random.Range(0, teamList.teamOneEnemy.Length);
            var obj = Instantiate(teamList.teamOneEnemy[randomEnemy], new Vector3(xPositionRandom, 0, zPositionRandom), teamList.teamOneEnemy[randomEnemy].transform.rotation);
            obj.transform.parent = EnemyListFatherObj.transform;
        }
        else if (teamNumberAsEnemy == 2)
        {
            int randomEnemy = Random.Range(0, teamList.teamTwoEnemy.Length);
            var obj = Instantiate(teamList.teamTwoEnemy[randomEnemy], new Vector3(xPositionRandom, 0, zPositionRandom), teamList.teamTwoEnemy[randomEnemy].transform.rotation);
            obj.transform.parent = EnemyListFatherObj.transform;
        }
        else if (teamNumberAsEnemy == 3)
        {
            int randomEnemy = Random.Range(0, teamList.teamThreeEnemy.Length);
            var obj = Instantiate(teamList.teamThreeEnemy[randomEnemy], new Vector3(xPositionRandom, 0, zPositionRandom), teamList.teamThreeEnemy[randomEnemy].transform.rotation);
            obj.transform.parent = EnemyListFatherObj.transform;
        }
        else if (teamNumberAsEnemy == 4)
        {
            int randomEnemy = Random.Range(0, teamList.teamFourEnemy.Length);
            var obj = Instantiate(teamList.teamFourEnemy[randomEnemy], new Vector3(xPositionRandom, 0, zPositionRandom), teamList.teamFourEnemy[randomEnemy].transform.rotation);
            obj.transform.parent = EnemyListFatherObj.transform;
        }
    }
}
