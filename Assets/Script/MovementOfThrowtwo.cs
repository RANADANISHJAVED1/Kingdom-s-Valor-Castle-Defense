using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfThrowtwo : MonoBehaviour
{
    public float speed;
    public GameObject stone;
    public Vector2 positionInstanciate;
    public bool start;
    private bool started;
    public float timeOfCoritine;
    public bool timeSet;
    public bool runStart;
    private void Start()
    {
        timeSet = false;
        runStart = false;
        start = false;
        started = true;
    }
    private void Update()
    {
        if (!timeSet)
        {
            StartCoroutine(timeSetter());
            timeSet = true;
        }
        if (start && started)
        {
            InvokeRepeating("instanciateStone", 2.5f, 6);
            this.gameObject.GetComponent<Animator>().SetTrigger("Start");
            started = false;
        }
        if (this.gameObject.transform.position.x >= 9 && runStart)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    IEnumerator timeSetter()
    {
        yield return new WaitForSeconds(timeOfCoritine);
        runStart = true;
    }
    public void instanciateStone()
    {
        var obj =Instantiate(stone, new Vector3(this.transform.position.x+positionInstanciate.x,this.transform.position.y+positionInstanciate.y,this.transform.position.z), stone.transform.rotation);
        obj.transform.parent = this.transform.parent;
    }
}
