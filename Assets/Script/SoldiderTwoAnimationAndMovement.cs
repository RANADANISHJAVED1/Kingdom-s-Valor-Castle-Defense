using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldiderTwoAnimationAndMovement : MonoBehaviour
{
    public int speed;
    private bool playOneTime;
    private bool diedBool;
    private Animator solider2animator;
    // Start is called before the first frame update
    void Start()
    {
        diedBool = false;
        playOneTime = false;
        solider2animator = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("animationOnredpeating",0,3);
    }

    // Update is called once per frame
    void Update()
    {
        if (!diedBool)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }   
    }
    void animationOnredpeating()
    {
        if (!diedBool)
        {
            solider2animator.SetTrigger("Attack");
        }
    }
    public void died()
    {
        if (!playOneTime)
        {
            diedBool = true;
            solider2animator.SetTrigger("Dying");
            speed = 0;
            playOneTime = true;
        }
    }
}
