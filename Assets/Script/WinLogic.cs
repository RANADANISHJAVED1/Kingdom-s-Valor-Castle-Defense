using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLogic : MonoBehaviour
{
    private EnemySpawn enemySpawn;
    private GameWinScriptOnEnemy[] gameWinScriptOnEnemies;
    public GameObject gameWinScreen;
    private void Start()
    {
        enemySpawn = GameObject.Find("GameManager").GetComponent<EnemySpawn>();   
    }
    private void Update()
    { 
        if(enemySpawn.thirdWaveTime<=0 && enemySpawn.loop <= 0)
        {
            gameWinScriptOnEnemies = this.gameObject.GetComponentsInChildren<GameWinScriptOnEnemy>();
            if (gameWinScriptOnEnemies.Length == 0)
            {
                gameWinScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
        
    }
}
