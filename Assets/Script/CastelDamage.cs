using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CastelDamage : MonoBehaviour
{
    public TextMeshProUGUI ourstrenthtxt;
    public TextMeshProUGUI enemystrenthtxt;
    public GameObject WinHealthTxt;
    public GameObject LoseHealthTxt;
    private Health health;
    [HideInInspector]
    public bool callOneTime;
    public GameObject gameLoseScreen;
    public GameObject gameWinScreen;
    // Start is called before the first frame update
    void Start()
    {
        health = this.gameObject.GetComponent<Health>();
        callOneTime = false;
        ourstrenthtxt.text = "Health : " + health.health.ToString();
        enemystrenthtxt.text = "Health : " + health.health.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name == "EndingWall (1)")
        {
            if (health.health <= 0)
            {
                gameLoseScreen.SetActive(true);
                LoseHealthTxt.SetActive(true);
                Time.timeScale = 0;
            }
        }
        if (this.gameObject.name == "StartingWall")
        {
            if (health.health <= 0)
            {
                gameWinScreen.SetActive(true);
                WinHealthTxt.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyDestroy"))
        {
            if (other.gameObject.name == "Stone(Clone)")
            {
                GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smokeInsFun(other.transform.position);
                health.healthDecrement(-40);
                ourstrenthtxt.text = "Health: " + health.health.ToString();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.name == "Enemyspear(Clone)")
            {
                health.healthDecrement(-20);
                GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x - 1.2f, other.transform.position.y, other.transform.position.z));
                ourstrenthtxt.text = "Health : " + health.health.ToString();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.name == "Arrow_01(Clone)")
            {
                health.healthDecrement(-10);
                GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                ourstrenthtxt.text = "Health : " + health.health.ToString();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.name == "Knife(Clone)")
            {
                GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                health.healthDecrement(-10);
                ourstrenthtxt.text = "Health : " + health.health.ToString();
                Destroy(other.gameObject);
            }
            
        }
        if (other.gameObject.CompareTag("PlayerDestroy"))
        {
            if (other.gameObject.name == "arrowPlayer(Clone)" || other.gameObject.name == "Knife For Static(Clone)")
            {
                GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x + 0.3f, other.transform.position.y, other.transform.position.z));
                health.healthDecrement(-5);
                enemystrenthtxt.text = "Health : " + health.health.ToString();
                Destroy(other.gameObject);

            }
            else if (other.gameObject.name == "CANNON FIRE BALL(Clone)" || other.gameObject.name == "cannon ball Prefab(Clone)")
            {
                GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().fireSmokeInsFun(new Vector3(other.transform.position.x + 0.1f, other.transform.position.y, other.transform.position.z));
                health.healthDecrement(-3);
                enemystrenthtxt.text = "Health : " + health.health.ToString();
                Destroy(other.gameObject);
            }
        }
    }
}
