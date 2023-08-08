using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassInstanciate : MonoBehaviour
{
    // public int column, row;
    // public float x_Space, z_Space;
    // public GameObject grass;
    //public GameObject fatherGround;
    private GameObject[] currentGrid;
    private BorderOnOff[] borderOnOffs;
    private bool gotGrid;
    public GameObject grass;
    private GameObject hitted;
    private GameObject creatingObject;
    private RaycastHit hit;
    private bool Creating = false;
    private TeamCards teamCards;
    void Start()
    {
        /** for(int i = 0; i < row * column; i++)
         {
            var obj = Instantiate(grass, new Vector3(x_Space + (x_Space * (i % column)), 0, z_Space + (z_Space * (i / column))), Quaternion.identity);
             obj.transform.parent = fatherGround.transform;
         }**/
        teamCards = this.gameObject.GetComponent<TeamCards>();
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
                        borderOf();
                    }
                }
            }
        }
    }
    public void firstObj()
    {
        creatingObject = teamCards.teamOneCards[0];
        Creating = true;
        borderOn();
    }
    public void secondObj()
    {
        creatingObject = teamCards.teamOneCards[1];
        Creating = true;
        borderOn();
    }
    public void thirdObj()
    {
        creatingObject = teamCards.teamOneCards[2];
        Creating = true;
        borderOn();
    }
    public void fourObj()
    {
        creatingObject = teamCards.teamTwoCards[0];
        Creating = true;
        borderOn();
    }
    public void fiveObj()
    {
        creatingObject = teamCards.teamTwoCards[1];
        Creating = true;
        borderOn();
    }
    public void sixObj()
    {
        creatingObject = teamCards.teamTwoCards[2];
        Creating = true;
        borderOn();
    }
    public void borderOn()
    {
        borderOnOffs = this.GetComponentsInChildren<BorderOnOff>();
        for (int i = 0; i < borderOnOffs.Length; i++)
        {
            borderOnOffs[i].BorderOn();
        }
    }
    public void borderOf()
    {
        borderOnOffs = this.GetComponentsInChildren<BorderOnOff>();
        for (int i = 0; i < borderOnOffs.Length; i++)
        {
            Debug.Log("PLAYED");
            borderOnOffs[i].BorderOff();
        }
    }
}
