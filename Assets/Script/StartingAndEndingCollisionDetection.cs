using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingAndEndingCollisionDetection : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyDestroy"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("PlayerDestroy"))
        {
            Destroy(other.gameObject);
        }

    }
}
