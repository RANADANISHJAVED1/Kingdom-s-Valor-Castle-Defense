using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    private bool callOneTime;
    private void Start()
    {
        callOneTime = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyDestroy"))
        {
            Destroy(other.gameObject);
            if (this.gameObject.name == "Turret Tower 03")
            {
                this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                {
                    this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                    Destroy(this.gameObject);
                }
            }
            else if (this.gameObject.name == "blue soldier")
            {
                this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                {
                    this.gameObject.GetComponent<BlueAnimationController>().died();
                    StartCoroutine(blueGrassCaller());
                }

            }
            else if (this.gameObject.name == "tower_defence")
            {
                this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                {
                    this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                    Destroy(this.gameObject);
                }
            }
            else if (this.gameObject.name == "soldierRemastered")
            {
                this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                {
                    this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                    StartCoroutine(blueGrassCaller());
                }
            }
            else if(this.gameObject.name == "Effect")
            {
                this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                {
                    this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                }
            }
        }
        else if (other.gameObject.CompareTag("ENEMY"))
        {
            if (this.gameObject.name == "Turret Tower 03")
            {
                if (other.gameObject.GetComponent<Health>().health > this.gameObject.GetComponentInParent<Health>().health)
                {
                    this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                    Destroy(this.gameObject);
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
                    if (other.gameObject.name == "Thrower 1(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "soldierRemastered(Clone)")
                    {
                        other.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "soldier2Remastered (1)(Clone)")
                    {
                        other.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "Throw 2(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "blue soldier Enemy(Clone)")
                    {
                        other.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                }
            }
            else if (this.gameObject.name == "blue soldier")
            {
                if (other.gameObject.GetComponent<Health>().health > this.gameObject.GetComponentInParent<Health>().health)
                {
                    this.gameObject.GetComponent<BlueAnimationController>().died();
                    StartCoroutine(blueGrassCaller());
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
                    if (other.gameObject.name == "Thrower 1(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "soldierRemastered(Clone)")
                    {
                        other.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "soldier2Remastered (1)(Clone)")
                    {
                        other.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "Throw 2(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "blue soldier Enemy(Clone)")
                    {
                        other.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                }

            }
            else if (this.gameObject.name == "tower_defence")
            {
                    if (other.gameObject.GetComponent<Health>().health > this.gameObject.GetComponentInParent<Health>().health)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                        Destroy(this.gameObject);
                    }
                    else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                    {
                        if (other.gameObject.name == "Thrower 1(Clone)")
                        {
                            Destroy(other.gameObject);
                        }
                        else if (other.gameObject.name == "soldierRemastered(Clone)")
                        {
                            other.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                            other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                        }
                        else if (other.gameObject.name == "soldier2Remastered (1)(Clone)")
                        {
                            other.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                            other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                        }
                        else if (other.gameObject.name == "Throw 2(Clone)")
                        {
                            Destroy(other.gameObject);
                        }
                        else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                        {
                            other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                            other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                        }
                        else if (other.gameObject.name == "blue soldier Enemy(Clone)")
                        {
                            other.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                            other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                        }
                    }

            }
            
            else if (this.gameObject.name == "soldierRemastered")
            {
                if (other.gameObject.GetComponent<Health>().health > this.gameObject.GetComponentInParent<Health>().health)
                {
                    this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                    StartCoroutine(blueGrassCaller());
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
                    if (other.gameObject.name == "Thrower 1(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "soldierRemastered(Clone)")
                    {
                        other.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "soldier2Remastered (1)(Clone)")
                    {
                        other.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "Throw 2(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "blue soldier Enemy(Clone)")
                    {
                        other.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                }
            }
            else if (this.gameObject.name == "Effect")
            {
                this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                {
                    this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                }
                else
                {
                    if (other.gameObject.name == "Thrower 1(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "soldierRemastered(Clone)")
                    {
                        other.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "soldier2Remastered (1)(Clone)")
                    {
                        other.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "Throw 2(Clone)")
                    {
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "blue soldier Enemy(Clone)")
                    {
                        other.gameObject.GetComponent<BlueEnemyAnimationController>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                }
            }
        }
    }
    IEnumerator blueGrassCaller()
    {
        yield return new WaitForSeconds(3);
        if (!callOneTime)
        {
            this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
            callOneTime = true;
        }
    }
}
