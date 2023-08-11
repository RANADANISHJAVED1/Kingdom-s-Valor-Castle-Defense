using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public void healthDecrement(int num)
    {
        if (health + num < 0)
        {
            health = 0;
        }
        else {
            health = health + num;
        }
        
        
    }
}
