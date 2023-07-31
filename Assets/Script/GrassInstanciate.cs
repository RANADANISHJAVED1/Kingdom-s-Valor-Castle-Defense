using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassInstanciate : MonoBehaviour
{
    // public int column, row;
    // public float x_Space, z_Space;
    // public GameObject grass;
    //public GameObject fatherGround;
    public GameObject[] currentGrid;
    private bool gotGrid;
    private GameObject hitted;
    private GameObject creatingObject;
    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    private RaycastHit hit;
    private bool Creating = false;
    void Start()
    {
       /** for(int i = 0; i < row * column; i++)
        {
           var obj = Instantiate(grass, new Vector3(x_Space + (x_Space * (i % column)), 0, z_Space + (z_Space * (i / column))), Quaternion.identity);
            obj.transform.parent = fatherGround.transform;
        }**/
    }

    // Update is called once per frame
    void Update()
    {
        if(gotGrid == false)
        {
            currentGrid = GameObject.FindGameObjectsWithTag("GRASS");
            gotGrid = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit))
            {
                if(Creating == true)
                {
                    if(hit.transform.tag == "GRASS")
                    {
                        hitted = hit.transform.gameObject;
                        var obj = Instantiate(creatingObject, hitted.transform.position, Quaternion.identity);
                        obj.transform.parent = this.transform;
                        Destroy(hitted);
                        Creating = false;
                    }
                }
            }
        }
    }
    public void firstObj()
    {
        creatingObject = First;
        Creating = true;
    }
    public void secondObj()
    {
        creatingObject = Second;
        Creating = true;
    }
    public void thirdObj()
    {
        creatingObject = Third;
        Creating = true;
    }
}
