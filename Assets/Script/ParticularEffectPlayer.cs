using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticularEffectPlayer : MonoBehaviour
{
    public ParticleSystem ring;
    public GameObject ringObj;
    private void Start()
    {
        ring.Play();
        StartCoroutine(ringOff());
    }
    IEnumerator ringOff()
    {
        yield return new WaitForSeconds(1.2f);
        ringObj.SetActive(false);
        Destroy(ringObj);    }
}
