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
            if(this.gameObject.name == "Turret Tower 03")
            {
                this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "blue soldier")
            {
                this.gameObject.GetComponent<BlueAnimationController>().died();
                StartCoroutine(blueGrassCaller());
                
            }
            else if (this.gameObject.name == "tower_defence")
            {
                this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "soldierRemastered")
            {
                this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                StartCoroutine(blueGrassCaller());
            }
        }
        else if (other.gameObject.CompareTag("ENEMY"))
        {
            if (this.gameObject.name == "Turret Tower 03")
            {
                this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "blue soldier")
            {
                this.gameObject.GetComponent<BlueAnimationController>().died();
                StartCoroutine(blueGrassCaller());

            }
            else if (this.gameObject.name == "tower_defence")
            {
                this.gameObject.GetComponentInParent<GroundReplaceWithGrass>().replace();
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "soldierRemastered")
            {
                this.gameObject.GetComponent<SitaticKnifeThrow>().Died();
                StartCoroutine(blueGrassCaller());
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
