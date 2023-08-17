using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLogic : MonoBehaviour
{
    private EnemySpawn enemySpawn;
    private GameWinScriptOnEnemy[] gameWinScriptOnEnemies;
    public GameObject gameWinScreen;
    public GameObject killAllEnemyTxt;
    [HideInInspector]
    public bool complete;
    private void Start()
    {
        enemySpawn = GameObject.Find("GameManager").GetComponent<EnemySpawn>();
        complete = false;
    }
    private void Update()
    { 
        if(enemySpawn.thirdWaveTime<=0 && enemySpawn.loop <= 0 && complete)
        {
            gameWinScriptOnEnemies = this.gameObject.GetComponentsInChildren<GameWinScriptOnEnemy>();
            if (gameWinScriptOnEnemies.Length == 0)
            {
                gameWinScreen.SetActive(true);
                killAllEnemyTxt.SetActive(true);
                Time.timeScale = 0;
            }
        }
        
    }
}
