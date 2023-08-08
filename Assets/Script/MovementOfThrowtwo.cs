using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfThrowtwo : MonoBehaviour
{
    public float speed;
    public GameObject stone;
    public Vector2 positionInstanciate;
    private void Start()
    {
        InvokeRepeating("instanciateStone", 2.5f,6);
    }
    private void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
    }
    public void instanciateStone()
    {
        var obj =Instantiate(stone, new Vector3(this.transform.position.x+positionInstanciate.x,this.transform.position.y+positionInstanciate.y,this.transform.position.z), stone.transform.rotation);
        obj.transform.parent = this.transform;
    }
}
