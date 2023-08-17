using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soliderRemasteredAnimation : MonoBehaviour
{
    private Animator SoliderAnimation;
    public  GameObject knifeObj;
    private float speed;
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
        if (!diedBool)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } 
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
        if (!diedBool)
        {
            instanciateKnife();
            SoliderAnimation.SetTrigger("Walking");
            speed = 0.1f;
        }
    }
    IEnumerator Speedzero()
    {
        yield return new WaitForSeconds(4);
        if (!diedBool)
        {
            speed = 0;
        }
    }
    void instanciateKnife()
    {
        if (!diedBool)
        {
            var obj = Instantiate(knifeObj, new Vector3(this.transform.position.x - 0.3f, this.transform.position.y + 0.35f, this.transform.position.z), knifeObj.transform.rotation);
            obj.transform.parent = this.transform.parent;
        }
    }
    public void died()
    {
        if (!playOneTime)
        {
            diedBool = true;
            SoliderAnimation.SetTrigger("Dying");
            speed = 0;
            playOneTime = true;
            StartCoroutine(GameObject.Find("GameManager").GetComponent<GameManagerParticularEffect>().bloodBonesExplisionEnemy(new Vector3(this.gameObject.transform.position.x - 0.2f, this.transform.position.y, this.transform.position.z),this.gameObject));
        }
    }
}
