using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePlayerColidersWin : MonoBehaviour
{
    int target = 0;
    public GameObject winScreen;
    public GameObject Wintext;
    private void Start()
    {
        winScreen.SetActive(false);
        Wintext.SetActive(false);
        target = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PLAYER"))
        {
            if (!other.gameObject.GetComponent<Checked>().check)
            {
                other.gameObject.GetComponent<Checked>().check = true;
                target++;
                if (target >= 3)
                {
                    winScreen.SetActive(true);
                    Wintext.SetActive(true);
                    Time.timeScale = 0;
                }
            }
            
        }
    }
}
