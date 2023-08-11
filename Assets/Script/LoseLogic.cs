using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseLogic : MonoBehaviour
{
    public GameObject gameLoseScreen;
    public TextMeshProUGUI strenthtxt;
    private Health health;
    public bool callOneTime;
    private void Start()
    {
        health = this.gameObject.GetComponent<Health>();
        callOneTime = false;
        gameLoseScreen.SetActive(false);
        strenthtxt.text = "Strength Of Castle : " + health.health.ToString();
    }
    private void Update()
    {
        if(health.health<=0 && !callOneTime)
        {
            gameLoseScreen.SetActive(true);
            Time.timeScale = 0;
            callOneTime = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ENEMY"))
        {
            gameLoseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.gameObject.CompareTag("EnemyDestroy"))
        {
            if(other.gameObject.name == "Stone(Clone)")
            {
                health.healthDecrement(-40);
                strenthtxt.text = "Strength Of Castle : " + health.health.ToString();
            }
            else if (other.gameObject.name == "Enemyspear(Clone)")
            {
                health.healthDecrement(- 20);
                strenthtxt.text = "Strength Of Castle : " + health.health.ToString();
            }
            else if (other.gameObject.name == "Arrow_01(Clone)")
            {
                health.healthDecrement(- 10);
                strenthtxt.text = "Strength Of Castle : " + health.health.ToString();
            }
            else if (other.gameObject.name == "Knife(Clone)")
            {
                health.healthDecrement(- 10);
                strenthtxt.text = "Strength Of Castle : " + health.health.ToString(); 
            }
            Destroy(other.gameObject);
        }

    }
}
