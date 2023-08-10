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
            speed = 0;
            BlueAnimController.SetTrigger("AttackOne");
            StartCoroutine(endAttack());
            StartCoroutine(walk());
            StartCoroutine(walkTwo());
        }
    }
    IEnumerator endAttack()
    {
        yield return new WaitForSeconds(0.5f);
        if (!diedBool)
        {
            BlueAnimController.SetTrigger("AttackTwo");
        }
    }
    IEnumerator walk()
    {
        yield return new WaitForSeconds(1.6f);
        if (!diedBool)
        {
            BlueAnimController.SetTrigger("Walk");
            speed = 0.7f;
        }
    }
    IEnumerator walkTwo()
    {
        yield return new WaitForSeconds(2f);
        if (!diedBool)
        {
            BlueAnimController.SetTrigger("Walk");
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
