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
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smokeInsFun(other.transform.position);
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-12);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
     
                }
                else if (this.gameObject.name == "tower_defence")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smokeInsFun(other.transform.position);
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-15);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
                }
            }
            else if (other.gameObject.name == "Knife(Clone)")
            {
                if (this.gameObject.name == "Turret Tower 03")
                {
;
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-6);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "tower_defence")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-6);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "blue soldier(Clone)")
                {
                    this.gameObject.GetComponent<Health>().healthDecrement(-6);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {  
                        this.gameObject.GetComponent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom")
                {
                    
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-6);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom_Helmet")
                {
                    
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-6);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "player Erika Archer With Bow Arrow 1(Clone)")
                {
                    
                    this.gameObject.GetComponent<Health>().healthDecrement(-6);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(this.gameObject.GetComponent<GroundReplaceWithGrass>().coin());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "soldierRemastered")
                {
                    
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-6);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                        StartCoroutine(blueGrassCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
            }
            else if (other.gameObject.name == "Enemyspear(Clone)")
            {
                if (this.gameObject.name == "Turret Tower 03")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x-1.2f,other.transform.position.y,other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "tower_defence")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x - 1.2f, other.transform.position.y, other.transform.position.z));

                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "blue soldier(Clone)")
                {
                   
                    this.gameObject.GetComponent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 1f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom")
                {
                   
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 1f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom_Helmet")
                {
                    
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 1f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "player Erika Archer With Bow Arrow 1(Clone)")
                {
                    
                    this.gameObject.GetComponent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(this.gameObject.GetComponent<GroundReplaceWithGrass>().coin());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 1f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "soldierRemastered")
                {
                    
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-7);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                        StartCoroutine(blueGrassCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x-1f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
            }
            else if(other.gameObject.name == "Arrow_01(Clone)")
            {
                if (this.gameObject.name == "Turret Tower 03")
                {
                    
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(new Vector3(other.gameObject.transform.position.x-0.2f,other.transform.position.y,other.transform.position.z));
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "tower_defence")
                {
                    GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().smallSmokeInsFun(other.transform.position);
                    Destroy(other.gameObject);
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().cannonreplace();
                        Destroy(this.gameObject);
                    }
                }
                else if (this.gameObject.name == "blue soldier(Clone)")
                {
                    
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom")
                {
                    
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "Paladin_J_Nordstrom_Helmet")
                {
                   
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponentInParent<BlueAnimationController>().died();
                        StartCoroutine(CoinCreater());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "player Erika Archer With Bow Arrow 1(Clone)")
                {
                    
                    this.gameObject.GetComponent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        StartCoroutine(this.gameObject.GetComponent<GroundReplaceWithGrass>().coin());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
                }
                else if (this.gameObject.name == "soldierRemastered")
                {
                    this.gameObject.GetComponentInParent<Health>().healthDecrement(-5);
                    if (this.gameObject.GetComponentInParent<Health>().health <= 0)
                    {
                        this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                        StartCoroutine(blueGrassCaller());
                    }
                    else
                    {
                        GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodExplision(new Vector3(other.gameObject.transform.position.x - 0.2f, other.transform.position.y, other.transform.position.z));
                    }
                    Destroy(other.gameObject);
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
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
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
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
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
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
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
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                        other.gameObject.GetComponent<EnemyCollisionDetection>().callOutsideObjDeletionCaller();
                    }
                }
            }
            else if (this.gameObject.name == "player Erika Archer With Bow Arrow 1(Clone)")
            {
                if (this.gameObject.GetComponent<Health>().health < other.gameObject.GetComponent<Health>().health)
                {
                    this.gameObject.GetComponent<erikaArcherAnimationController>().dying();
                   
                    StartCoroutine(this.gameObject.GetComponent<GroundReplaceWithGrass>().coin());
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
                    else if (other.gameObject.name == "Erika Archer With Bow Arrow(Clone)")
                    {
                        other.gameObject.GetComponent<erikaArcherAnimationController>().dying();
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
    IEnumerator CoinCreater()
    {
        yield return new WaitForSeconds(3);
        if (!callOneTime)
        {
            StartCoroutine(this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().coin());
            callOneTime = true;
        }
    }
}
