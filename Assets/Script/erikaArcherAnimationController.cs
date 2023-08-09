using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class erikaArcherAnimationController : MonoBehaviour
{
    private Animator erikaArcherController;
    public GameObject arrow;
    public int speed;
    private bool diedBool;
    private bool playOneTime;
    private void Start()
    {
        playOneTime = false;
        diedBool = false;
        erikaArcherController = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("aimanimation", 0, 3);
    }
    private void Update()
    {
        if (!diedBool)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    void aimanimation()
    {
        if (!diedBool)
        {
            erikaArcherController.SetTrigger("aimTrigger");
            StartCoroutine(recoilAnim());
            StartCoroutine(walking());
            StartCoroutine(Speedzero());
        }
    }
    IEnumerator recoilAnim()
    {
        yield return new WaitForSeconds(1);
        if (!diedBool)
        {
            instanciateArrow();
            erikaArcherController.SetTrigger("recoilAnimation");
        }
    }
    void instanciateArrow()
    {
        var obj =Instantiate(arrow, new Vector3(this.transform.position.x-0.461f, this.transform.position.y+ 0.7f, this.transform.position.z+ 0.149f),arrow.transform.rotation);
        obj.transform.parent = this.transform.parent;
    }
    IEnumerator walking()
    {
        yield return new WaitForSeconds(2);
        if (!diedBool)
        {
            speed = 1;
            erikaArcherController.SetTrigger("walking");
        }
    }
    IEnumerator Speedzero()
    {
        yield return new WaitForSeconds(3);
        if (!diedBool)
        {
            speed = 0;
        }
    }
    public void dying()
    {
        if (!playOneTime)
        {
            diedBool = true;
            speed = 0;
            playOneTime = true;
            erikaArcherController.SetTrigger("Dying");
        }
    }
}
