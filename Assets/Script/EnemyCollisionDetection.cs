using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDetection : MonoBehaviour
{
    private bool playOneTime;
    public GameObject coin;
    private void Start()
    {
        playOneTime = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerDestroy"))
        {
            if(other.gameObject.name == "CANNON FIRE BALL(Clone)" || other.gameObject.name == "cannon ball Prefab(Clone)")
            {
                Destroy(other.gameObject);
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-120);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionCaller());
                    }
                }
            }
            else if (other.gameObject.name == "arrowPlayer(Clone)")
            {
                Destroy(other.gameObject);
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionCaller());
                    }
                }
                else if (this.gameObject.name == "soldierRemastered(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                }
                else if (this.gameObject.name == "soldier2Remastered (1)(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                }
            }
            else if (other.gameObject.name == "Knife For Static(Clone)")
            {
                Destroy(other.gameObject);
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-20);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionCaller());
                    }
                }
                else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(objDeletionCaller());
                    }
                }
                else if (this.gameObject.name == "blue soldier Enemy(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                }

            }
            else if (other.gameObject.name == "Playerspear2(Clone)")
            {
                Destroy(other.gameObject);
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionCaller());
                    }
                }
                else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(objDeletionCaller());
                    }
                }
                else if (this.gameObject.name == "blue soldier Enemy(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                }

            }
            
           /* if (this.gameObject.name == "soldierRemastered(Clone)")
            {
                this.gameObject.GetComponent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponent<Health>().health <= 0)
                {
                    this.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                    StartCoroutine(objDeletionCaller());
                }
            }
            else if(this.gameObject.name == "soldier2Remastered (1)(Clone)")
            {
                this.gameObject.GetComponent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponent<Health>().health <= 0)
                {
                    this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                    StartCoroutine(objDeletionCaller());
                }
            }
            else if(this.gameObject.name == "Throw 2(Clone)")
            {
                this.gameObject.GetComponent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponent<Health>().health <= 0)
                {
                    StartCoroutine(objDeletionCaller());
                }
            }
            else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
            {
                this.gameObject.GetComponent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponent<Health>().health <= 0)
                {
                    this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                    StartCoroutine(objDeletionCaller());
                }
            }
            else if (this.gameObject.name == "blue soldier Enemy(Clone)")
            {
                this.gameObject.GetComponent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponent<Health>().health <= 0)
                {
                    this.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                    StartCoroutine(objDeletionCaller());
                }
            }*/
        }
       /** else if (other.gameObject.CompareTag("PLAYER"))
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
        }**/
    }
    IEnumerator objDeletionCaller()
    {
        yield return new WaitForSeconds(3);
        if (!playOneTime)
        {
            Instantiate(coin,new Vector3( this.gameObject.transform.position.x, 0.381f,this.gameObject.transform.position.z), coin.transform.rotation);
            Destroy(this.gameObject);
            playOneTime= true;
        }
    }
    public void diectobjDeletionCaller()
    {
        if (!playOneTime)
        {
            Instantiate(coin, new Vector3(this.gameObject.transform.position.x, 0.381f, this.gameObject.transform.position.z), coin.transform.rotation);
            Destroy(this.gameObject);
            playOneTime = true;
        }
    }
    public void callOutsideObjDeletionCaller()
    {
        StartCoroutine(objDeletionCaller());
    }
}
