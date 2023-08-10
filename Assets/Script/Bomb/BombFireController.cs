using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFireController : MonoBehaviour
{
    public GameObject[] bomb;
    public GameObject FireObj;
    public ParticleSystem fire;
    private bool hitted;
    
    private void Start()
    {
        FireObj.SetActive(false);
        hitted = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ENEMY") && !hitted)
        {
            for (int i = 0; i < 9; i++)
            {
                Destroy(bomb[i]);
            }
            hitted = true;
            Destroy(other.gameObject);
            FireObj.SetActive(true);
            fire.Play();
            StartCoroutine(fireCloser());
        }
    }
    IEnumerator fireCloser()
    {
        yield return new WaitForSeconds(1f);
        Destroy(fire);
        this.gameObject.GetComponent<GroundReplaceWithGrass>().replace();
    }
}
