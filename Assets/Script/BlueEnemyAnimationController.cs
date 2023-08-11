using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemyAnimationController : MonoBehaviour
{
    private Animator blueEnemyAnimator;
    private float speed;
    bool diedBool;
    bool callOneTime;
    private void Start()
    {
        diedBool = false;
        callOneTime = false;
        blueEnemyAnimator = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("startAnimation",0,2.4f);
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
            speed = 0.5f;
            blueEnemyAnimator.SetTrigger("Walk");
            StartCoroutine("attack");
        }
    }
    IEnumerator attack()
    {
        yield return new WaitForSeconds(1);
        if (!diedBool)
        {
            blueEnemyAnimator.SetTrigger("Attack");
            speed = 0;
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
