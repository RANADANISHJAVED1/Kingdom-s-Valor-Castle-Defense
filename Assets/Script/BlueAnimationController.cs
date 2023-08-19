using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAnimationController : MonoBehaviour
{
    private Animator BlueAnimController;
    private bool diedBool;
    private bool callOneTime;
    private float speed;
  
    void Start()
    {
        callOneTime = false;
        diedBool = false;
        BlueAnimController = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("startAnim",0, 2.4f);
    }
    private void Update()
    {
        if (!diedBool)
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    void startAnim()
    {
        if (!diedBool)
        {
            speed = 0.3f;
            BlueAnimController.SetTrigger("Walk");
            StartCoroutine(attack());
        }
    }
    IEnumerator attack()
    {
        yield return new WaitForSeconds(1);
        if (!diedBool)
        {
            speed = 0;
            BlueAnimController.SetTrigger("Attack");
        }
       
    }
    public void died()
    {
        if (!callOneTime)
        {
            callOneTime = true;
            diedBool = true;
            BlueAnimController.SetTrigger("Dying");
            StartCoroutine( GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodBonesExplisionEnemy(this.transform.position,this.gameObject));
        }
    }
    
}
