using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDetection : MonoBehaviour
{
    private bool playOneTime;
    private void Start()
    {
        playOneTime = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerDestroy"))
        {
            Destroy(other.gameObject);
            if(this.gameObject.name == "Thrower 1")
            {
                Destroy(this.gameObject);
            }
            else if(this.gameObject.name == "soldierRemastered(Clone)")
            {
                this.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                StartCoroutine(objDeletionCaller());
            }
            else if(this.gameObject.name == "soldier2Remastered (1)(Clone)")
            {
                this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                StartCoroutine(objDeletionCaller());
            }
            else if(this.gameObject.name == "Throw 2(Clone)")
            {
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
            {
                this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                StartCoroutine(objDeletionCaller());
            }
            else if (this.gameObject.name == "Throw 2(Clone)")
            {
                Destroy(this.gameObject);
            }
        }
        else if (other.gameObject.CompareTag("PLAYER"))
        {
            if (this.gameObject.name == "Thrower 1")
            {
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "soldierRemastered(Clone)")
            {
                this.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                StartCoroutine(objDeletionCaller());
            }
            else if (this.gameObject.name == "soldier2Remastered (1)(Clone)")
            {
                this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                StartCoroutine(objDeletionCaller());
            }
            else if (this.gameObject.name == "Throw 2(Clone)")
            {
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
            {
                this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                StartCoroutine(objDeletionCaller());
            }
            else if (this.gameObject.name == "Throw 2(Clone)")
            {
                Destroy(this.gameObject);
            }
        }
    }
    IEnumerator objDeletionCaller()
    {
        yield return new WaitForSeconds(3);
        if (!playOneTime)
        {
            Destroy(this.gameObject);
            playOneTime= true;
        }
    }
}
