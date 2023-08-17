using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerAnimationStarter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ENEMY"))
        {
            other.gameObject.GetComponent<MovementOfThrowtwo>().start = true;
        }
    }
}
