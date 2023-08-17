using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeCreaterController : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(delete());
    }
    IEnumerator delete()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
