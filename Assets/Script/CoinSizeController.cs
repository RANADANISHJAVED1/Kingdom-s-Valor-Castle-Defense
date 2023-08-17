using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSizeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Size");
        StartCoroutine(CoinRotate());
    }
    IEnumerator CoinRotate()
    {
        yield return new WaitForSeconds(2);
        this.gameObject.GetComponent<Animator>().SetTrigger("Rotate");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
