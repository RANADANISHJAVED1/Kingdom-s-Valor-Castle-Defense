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
            if(other.gameObject.name == "Stone(Clone)")
            {
                if (this.gameObject.name == "Turret Tower 03")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-100);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "tower_defence")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-50);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                        Destroy(this.gameObject);
                    }
                }
            }
            else if (other.gameObject.name == "Knife(Clone)")
            {
                if (this.gameObject.name == "Turret Tower 03")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-20);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "blue soldier(Clone)")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-20);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-20);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom_Helmet")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-20);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                }
                else if (this.gameObject.name == "player Erika Archer With Bow Arrow 1(Clone)")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-20);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        this.gameObject.GetComponent<GroundReplaceWithGrass>().coin();
                    }
                }
            }
            else if (other.gameObject.name == "Enemyspear(Clone)")
            {
                if (this.gameObject.name == "Turret Tower 03")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "blue soldier(Clone)")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom_Helmet")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                }
                else if (this.gameObject.name == "player Erika Archer With Bow Arrow 1(Clone)")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        this.gameObject.GetComponent<GroundReplaceWithGrass>().coin();
                    }
                }
            }
            else if(other.gameObject.name == "Arrow_01(Clone)")
            {
                if (this.gameObject.name == "soldierRemastered")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                        StartCoroutine(blueGrassCaller());
                    }
                }
                else if(this.gameObject.name == "Playersoldier2Remastered(Clone)")
                {
                    Destroy(other.gameObject);
                    this.gameObject.GetComponent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        StartCoroutine(CoinCreater());
                    }
                }
                else if(this.gameObject.name == "tower_defence")
                {
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-40);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                        Destroy(this.gameObject);
                    }
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
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
                    
                    if (other.gameObject.name == "soldierRemastered(Clone)")
                    {
                        other.gameObject.GetComponent<soliderRemasteredAnimation>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                    else if (other.gameObject.name == "soldier2Remastered (1)(Clone)")
                    {
                        other.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                }
            }
            else if (this.gameObject.name == "blue soldier(Clone)")
            {
                if (other.gameObject.GetComponent<Health>().health > this.gameObject.GetComponent<Health>().health)
                {
                    this.gameObject.GetComponent<BlueAnimationController>().died();
                    StartCoroutine(CoinCreater());
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponent<Health>().health)
                {
                    if (other.gameObject.name == "soldierRemastered(Clone)")
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
                        other.gameObject.GetComponent<EnemyCollisionDetection>().diectobjDeletionCaller();
                    }
                }
            }
            else if (this.gameObject.name == "tower_defence")
            {
                if (other.gameObject.GetComponent<Health>().health > this.gameObject.GetComponentInParent<Health>().health)
                {
                    this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                    
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
                    if (other.gameObject.name == "Throw 2(Clone)")
                    {
                        other.gameObject.GetComponent<EnemyCollisionDetection>().diectobjDeletionCaller();
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
                    
                    if (other.gameObject.name == "Throw 2(Clone)")
                    {
                        other.gameObject.GetComponent<EnemyCollisionDetection>().diectobjDeletionCaller();
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
            else if (this.gameObject.name == "Playersoldier2Remastered(Clone)")
            {
                
                if (this.gameObject.GetComponentInParent<Health>().health < other.gameObject.GetComponent<Health>().health)
                {
                    this.gameObject.GetComponent<SoldiderTwoAnimationAndMovement>().died();
                    StartCoroutine(CoinCreater());
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {

                    if (other.gameObject.name == "Throw 2(Clone)")
                    {
                        other.gameObject.GetComponent<EnemyCollisionDetection>().diectobjDeletionCaller();
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
            else if (this.gameObject.name == "Paladin_J_Nordstrom")
            {
                if (this.gameObject.GetComponentInParent<Health>().health < other.gameObject.GetComponent<Health>().health)
                {
                    this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                    StartCoroutine(CoinCreater());
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
          
                   if (other.gameObject.name == "soldierRemastered(Clone)")
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
                        other.gameObject.GetComponent<EnemyCollisionDetection>().diectobjDeletionCaller();
                    }
                }
            }
            else if (this.gameObject.name == "Paladin_J_Nordstrom_Helmet")
            {
                if (this.gameObject.GetComponentInParent<Health>().health < other.gameObject.GetComponent<Health>().health)
                {
                    this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                    StartCoroutine(CoinCreater());
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
                     if (other.gameObject.name == "soldierRemastered(Clone)")
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
                        other.gameObject.GetComponent<EnemyCollisionDetection>().diectobjDeletionCaller();
                    }
                }
            }
            else if (this.gameObject.name == "player Erika Archer With Bow Arrow 1(Clone)")
            {
                if (this.gameObject.GetComponent<Health>().health < other.gameObject.GetComponent<Health>().health)
                {
                    this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                    this.gameObject.GetComponent<GroundReplaceWithGrass>().coin();
                }
                else if (other.gameObject.GetComponent<Health>().health <= this.gameObject.GetComponentInParent<Health>().health)
                {
      
                    if (other.gameObject.name == "soldierRemastered(Clone)")
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
                        other.gameObject.GetComponent<EnemyCollisionDetection>().diectobjDeletionCaller();
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
    IEnumerator CoinCreater()
    {
        yield return new WaitForSeconds(3);
        if (!callOneTime)
        {
            this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().coin();
            callOneTime = true;
        }
    }
}
