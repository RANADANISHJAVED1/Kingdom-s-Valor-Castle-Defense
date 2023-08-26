using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseLogic : MonoBehaviour
{
    public GameObject gameLoseScreen;
    public GameObject LoseScreenText;
    int check = 3;
    int increment = 0;
    
    private void Start()
    {
        
       
        gameLoseScreen.SetActive(false);
        LoseScreenText.SetActive(false);

    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ENEMY"))
        {
            if (!other.gameObject.GetComponent<Checked>().check)
            {
                other.gameObject.GetComponent<Checked>().check = true;
                increment++;
                if (increment >= check)
                {
                    gameLoseScreen.SetActive(true);
                    LoseScreenText.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
      

    }
}
