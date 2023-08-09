using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitaticKnifeThrow : MonoBehaviour
{
    private Animator SoliderAnimation;
    public GameObject knifeObj;
    private bool DiedBool;
    private bool callOneTime;
    void Start()
    {
        callOneTime = false;
        DiedBool = false;
        SoliderAnimation = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("walkingAndThrowController", 0, 2);
    }

    // Update is called once per frame
    void walkingAndThrowController()
    {
        if (!DiedBool)
        {
            SoliderAnimation.SetTrigger("Throw");
            StartCoroutine(throwing());
        }
    }
    IEnumerator throwing()
    {
        yield return new WaitForSeconds(2);
        if (!DiedBool)
        {
            instanciateKnife();
        }
    }
    void instanciateKnife()
    {
        if (!DiedBool)
        {
            var obj = Instantiate(knifeObj, new Vector3(this.transform.position.x + 0.461f, this.transform.position.y + 0.7f, this.transform.position.z + 0.149f), knifeObj.transform.rotation);
            obj.transform.parent = this.transform.parent;
        }
    }
    public void Died()
    {
        if (!callOneTime)
        {
            DiedBool = true;
            SoliderAnimation.SetTrigger("Died");
            callOneTime = true;
        }
    }
}
