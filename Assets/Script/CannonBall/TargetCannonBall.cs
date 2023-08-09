using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCannonBall : MonoBehaviour
{
    public GameObject ObjectToInstanciate;
    public int LenghtOfTarget;
    public int Speed;
    public int startingtime;
    public float instanciateposition;

    private void Start()
    {
        InvokeRepeating("spawnObject", 0, startingtime);
    }
    private void spawnObject()
    {
        var obj = Instantiate(ObjectToInstanciate, new Vector3(this.transform.position.x,this.transform.position.y+ instanciateposition,this.transform.position.z), ObjectToInstanciate.transform.rotation);
        obj.GetComponent<LengthAndMovementCannonBall>().length = LenghtOfTarget;
        obj.GetComponent<LengthAndMovementCannonBall>().speed = Speed;
        obj.transform.parent = this.gameObject.transform.parent;
    }
}
