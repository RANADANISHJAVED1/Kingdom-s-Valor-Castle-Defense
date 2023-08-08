using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundReplaceWithGrass : MonoBehaviour
{
    public GameObject grassObj;
    private GameObject old;
    public void replace()
    {
        old = this.transform.gameObject;
        var obj = Instantiate(grassObj, old.transform.position, old.transform.rotation);
        obj.transform.parent = this.transform.parent;
        Destroy(old);
    }
}
