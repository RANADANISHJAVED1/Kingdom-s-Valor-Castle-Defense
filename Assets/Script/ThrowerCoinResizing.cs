using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerCoinResizing : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Resize");
        StartCoroutine(rotate());
    }
    IEnumerator rotate()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.GetComponent<Animator>().SetTrigger("Rotate");
    }
}
