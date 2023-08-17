using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundReplaceWithGrass : MonoBehaviour
{
    public GameObject grassObj;
    public GameObject CannongrassObj;
    private GameObject old;
    public GameObject coinObj;
    public void replace()
    {
        old = this.transform.gameObject;
        var obj = Instantiate(grassObj, old.transform.position, old.transform.rotation);
        obj.transform.parent = this.transform.parent;
        Destroy(old);
    }
    public void cannonreplace()
    {
        old = this.transform.gameObject;
        var obj = Instantiate(CannongrassObj, old.transform.position, old.transform.rotation);
        obj.transform.parent = this.transform.parent;
        Destroy(old);
    }
     public IEnumerator coin()
    {
        yield return new WaitForSeconds(3);
        old = this.transform.gameObject;
        //var obj = Instantiate(coinObj, new Vector3(this.gameObject.transform.position.x, 0.381f, this.gameObject.transform.position.z),coinObj.transform.rotation);
        //obj.transform.parent = this.transform.parent;
        Destroy(old);

    }
}
