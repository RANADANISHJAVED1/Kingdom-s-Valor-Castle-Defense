using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldiderTwoAnimationAndMovement : MonoBehaviour
{
    private float speed;
    private bool playOneTime;
    private bool diedBool;
    private Animator solider2animator;
    public GameObject naiza;
    public Vector3 addInPosition;
    // Start is called before the first frame update
    void Start()
    {
        diedBool = false;
        playOneTime = false;
        solider2animator = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("animationOnredpeating",0,2.5f);
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
        StartCoroutine(Walk());
        StartCoroutine(Attack());
        StartCoroutine(naizaInstanciate());
    }
    IEnumerator Walk()
    {
        yield return new WaitForSeconds(0);
        if (!diedBool)
        {
            solider2animator.SetTrigger("Walk");
            speed = 0.3f;
        }
    }
    IEnumerator Attack()
    {
        yield return new WaitForSeconds(1);
        if (!diedBool)
        {
            solider2animator.SetTrigger("Attack");
            speed = 0;
        }
    }
    IEnumerator naizaInstanciate()
    {
        yield return new WaitForSeconds(2f);
      if(!diedBool)
        {
            Instantiate(naiza, new Vector3(this.transform.position.x + addInPosition.x, this.transform.position.y + addInPosition.y, this.transform.position.z + addInPosition.z), naiza.transform.rotation);
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
