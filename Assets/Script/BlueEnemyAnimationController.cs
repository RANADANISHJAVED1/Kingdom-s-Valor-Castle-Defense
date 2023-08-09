using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemyAnimationController : MonoBehaviour
{
    private Animator blueEnemyAnimator;
    private int speed;
    bool diedBool;
    bool callOneTime;
    private void Start()
    {
        diedBool = false;
        callOneTime = false;
        blueEnemyAnimator = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("startAnimation",0,4.2f);
    }
    private void FixedUpdate()
    {
        if (!diedBool)
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    private void startAnimation()
    {
        if (!diedBool)
        {
            speed = 0;
            blueEnemyAnimator.SetTrigger("AttackOne");
            StartCoroutine(attackTwo());
            StartCoroutine(walk());
        }
    }
    IEnumerator attackTwo()
    {
        yield return new WaitForSeconds(2.3f);
        if (!diedBool)
        {
            blueEnemyAnimator.SetTrigger("AttackTwo");

        }
    }
    IEnumerator walk()
    {
        yield return new WaitForSeconds(3.4f);
        if (!diedBool)
        {
            blueEnemyAnimator.SetTrigger("Walk");
            speed = 2;
        }
    }
    public void died()
    {
        if (!callOneTime)
        {
            diedBool = true;
            blueEnemyAnimator.SetTrigger("Dying");
            speed = 0;
            callOneTime = true;
        }
    }
}
