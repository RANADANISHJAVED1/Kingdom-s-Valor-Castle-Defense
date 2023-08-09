using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOnCannonBallTwo : MonoBehaviour
{
    public GameObject ObjectToInstanciate;
    public int LenghtOfTarget;
    public float Speed;
    public int startingtime;
    public float instanciateposition;

    private void Start()
    {
        InvokeRepeating("spawnObject", 0f, startingtime);
    }
    private void spawnObject()
    {
        var obj = Instantiate(ObjectToInstanciate, new Vector3(this.transform.position.x, this.transform.position.y + instanciateposition, this.transform.position.z), ObjectToInstanciate.transform.rotation);
        obj.GetComponent<LengthAndMovementCannonBallTwo>().length = LenghtOfTarget;
        obj.GetComponent<LengthAndMovementCannonBallTwo>().speed = Speed;
        obj.transform.parent = this.gameObject.transform.parent;
    }
}
