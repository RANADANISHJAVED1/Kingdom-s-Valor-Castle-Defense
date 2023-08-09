using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLogic : MonoBehaviour
{
    public GameObject gameLoseScreen;
    private void Start()
    {
        gameLoseScreen.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ENEMY"))
        {
            gameLoseScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
