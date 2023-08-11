using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderOnOff : MonoBehaviour
{
    public GameObject border;
    public bool cannonGrass;
    private void Start()
    {
        border.SetActive(false);
    }
    public void BorderOn()
    {
        border.SetActive(true);
    }
    public void BorderOff()
    {
        border.SetActive(false);
    }
}
