using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soliderRemasteredAnimation : MonoBehaviour
{
    private Animator SoliderAnimation;
    public  GameObject knifeObj;
    private int speed;
    private bool playOneTime;
    private bool diedBool;
    void Start()
    {
        diedBool = false;
        playOneTime = false;
        SoliderAnimation = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("walkingAndThrowController", 0, 4);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward* speed * Time.deltaTime);
    }
    void walkingAndThrowController()
    {
        if (!diedBool)
        {
            SoliderAnimation.SetTrigger("Throw");
            StartCoroutine(throwing());
            StartCoroutine(Speedzero());
        }
    }
    IEnumerator throwing()
    {
        yield return new WaitForSeconds(2);
        instanciateKnife();
        SoliderAnimation.SetTrigger("Walking");
        speed = 1;
    }
    IEnumerator Speedzero()
    {
        yield return new WaitForSeconds(4);
        speed = 0;

    }
    void instanciateKnife()
    {
        var obj = Instantiate(knifeObj, new Vector3(this.transform.position.x - 0.461f, this.transform.position.y + 0.7f, this.transform.position.z + 0.149f), knifeObj.transform.rotation);
        obj.transform.parent = this.transform;
    }
    public void died()
    {
        if (!playOneTime)
        {
            diedBool = true;
            SoliderAnimation.SetTrigger("Dying");
            speed = 0;
            playOneTime = true;
        }
        
    }

}
