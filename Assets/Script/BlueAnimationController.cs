using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAnimationController : MonoBehaviour
{
    private Animator BlueAnimController;
    private bool diedBool;
    private bool callOneTime;
    void Start()
    {
        callOneTime = false;
        diedBool = false;
        BlueAnimController = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("startAnim",0, 3.6f);
    }

    void startAnim()
    {
        if (!diedBool)
        {
            BlueAnimController.SetTrigger("AttackOne");
            StartCoroutine(endAttack());
        }
    }
    IEnumerator endAttack()
    {
        yield return new WaitForSeconds(1.3f);
        if (!diedBool)
        {
            BlueAnimController.SetTrigger("AttackTwo");
        }
        
    }
    public void died()
    {
        if (!callOneTime)
        {
            diedBool = true;
            BlueAnimController.SetTrigger("Dying");
            callOneTime = true;
        }
    }
    
}
