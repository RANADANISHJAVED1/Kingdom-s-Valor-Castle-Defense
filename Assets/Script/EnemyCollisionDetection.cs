using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDetection : MonoBehaviour
{
    private bool playOneTime;
    public GameObject coin;
    public GameObject coinThrower;
    private void Start()
    {
        playOneTime = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerDestroy"))
        {
            if(other.gameObject.name == "CANNON FIRE BALL(Clone)")
            {
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().fireSmokeInsFun(new Vector3(other.transform.position.x + 0.1f, other.transform.position.y, other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-15);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionForThrower());
                    }
                }
            }
            else if (other.gameObject.name == "cannon ball Prefab(Clone)")
            {
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().fireSmokeInsFun(new Vector3(other.transform.position.x + 0.1f, other.transform.position.y, other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-10);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionForThrower());
                    }
                }
            }
            else if (other.gameObject.name == "arrowPlayer(Clone)")
            {
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x + 0.33f, other.transform.position.y, other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionForThrower());
                    }
                }
                else if (this.gameObject.name == "soldierRemastered(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "soldier2Remastered (1)(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
            }
            else if (other.gameObject.name == "Knife For Static(Clone)")
            {
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionForThrower());
                    }
                }
                else if (this.gameObject.name == "soldierRemastered(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "soldier2Remastered (1)(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
            }
            else if (other.gameObject.name == "Playerspear2(Clone)")
            {
                if (this.gameObject.name == "Throw 2(Clone)")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-8);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        StartCoroutine(objDeletionForThrower());
                    }
                }
                else if (this.gameObject.name == "soldierRemastered(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-8);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "soldier2Remastered (1)(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-8);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-8);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(objDeletionCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x + 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
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
    IEnumerator objDeletionForThrower()
    {
        yield return new WaitForSeconds(2F);
        if (!playOneTime)
        {
            Destroy(this.gameObject);
            Instantiate(coinThrower, new Vector3(this.gameObject.transform.position.x, 0.381f, this.gameObject.transform.position.z), coin.transform.rotation);
            playOneTime = true;
        }
    }
    IEnumerator objDeletionCaller()
    {
        yield return new WaitForSeconds(2F);
        if (!playOneTime)
        {
            Instantiate(coin,new Vector3( this.gameObject.transform.position.x, 0.381f,this.gameObject.transform.position.z), coin.transform.rotation);
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
