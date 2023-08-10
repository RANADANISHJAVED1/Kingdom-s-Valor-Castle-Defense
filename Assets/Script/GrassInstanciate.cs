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
    private bool obj1;
    private bool obj2;
    private bool obj3;
    private bool obj4;
    private bool obj5;
    private bool obj6;
    void Start()
    {
        /** for(int i = 0; i < row * column; i++)
         {
            var obj = Instantiate(grass, new Vector3(x_Space + (x_Space * (i % column)), 0, z_Space + (z_Space * (i / column))), Quaternion.identity);
             obj.transform.parent = fatherGround.transform;
         }**/
        teamCards = this.gameObject.GetComponent<TeamCards>();
        obj1 = false;
        obj2 = false;
        obj3 = false;
        obj4 = false;
        obj5 = false;
        obj6 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gotGrid == false)
        {
            currentGrid = GameObject.FindGameObjectsWithTag("GRASS");
            gotGrid = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (Creating == true)
                {
                    if (hit.transform.tag == "GRASS")
                    {
                        if (obj1 || obj4 || obj5 || obj6)
                        {
                            hitted = hit.transform.gameObject;
                            var obj = Instantiate(creatingObject, hitted.transform.position, Quaternion.identity);
                            obj.transform.parent = this.transform;
                            Destroy(hitted);
                            Creating = false;
                            borderOf();
                            AddCoinsAndOffButton();
                        }
                        else if(obj2 || obj3)
                        {
                            hitted = hit.transform.gameObject;
                            var obj = Instantiate(creatingObject,hitted.transform.position,creatingObject.transform.rotation);
                            obj.transform.parent = this.transform;
                            Creating = false;
                            borderOf();
                            AddCoinsAndOffButton();
                        }
                    }
                }
                else if (hit.transform.tag == "Ash")
                {
                    GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(25);
                    GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
                    hitted = hit.transform.gameObject;
                    var obj = Instantiate(grass, hitted.transform.position, Quaternion.identity);
                    obj.transform.parent = this.transform;
                    Destroy(hitted);
                }
                else if (hit.transform.tag == "AshPlayer")
                {
                    GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(25);
                    GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
                    hitted = hit.transform.parent.gameObject;
                    var obj = Instantiate(grass, hitted.transform.position, Quaternion.identity);
                    obj.transform.parent = this.transform;
                    Destroy(hitted);
                }
                else if (hit.transform.tag == "AshEnemy")
                {
                    GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(25);
                    GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
                    hitted = hit.transform.gameObject;
                    Destroy(hitted);
                }
            }
        }
    }
    private void AddCoinsAndOffButton()
    {
        if (obj1)
        {
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(-25);
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
            obj1 = false;
        }
        else if (obj2)
        {
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(-30);
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
            obj2 = false;
        }
        else if (obj3)
        {
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(-50);
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
            obj3 = false;
        }
        else if (obj4)
        {
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(-25);
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
            obj4 = false;
        }
        else if (obj5)
        {
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(-30);
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
            obj5 = false;
        }
        else if (obj6)
        {
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(-50);
            GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().checkButtonActivation();
            obj6 = false;
        }
    }
    public void firstObj()
    {
        creatingObject = teamCards.teamOneCards[0];
        Creating = true;
        borderOn();
        obj1 = true;
        obj2 = false;
        obj3 = false;
        obj4 = false;
        obj5 = false;
        obj6 = false;
    }
    public void secondObj()
    {
        creatingObject = teamCards.teamOneCards[1];
        Creating = true;
        borderOn();
        obj1 = false;
        obj2 = true;
        obj3 = false;
        obj4 = false;
        obj5 = false;
        obj6 = false;
    }
    public void thirdObj()
    {
        creatingObject = teamCards.teamOneCards[2];
        Creating = true;
        borderOn();
        obj1 = false;
        obj2 = false;
        obj3 = true;
        obj4 = false;
        obj5 = false;
        obj6 = false;
    }
    public void fourObj()
    {
        creatingObject = teamCards.teamTwoCards[0];
        Creating = true;
        borderOn();
        obj1 = false;
        obj2 = false;
        obj3 = false;
        obj4 = true;
        obj5 = false;
        obj6 = false;
    }
    public void fiveObj()
    {
        creatingObject = teamCards.teamTwoCards[1];
        Creating = true;
        borderOn();
        obj1 = false;
        obj2 = false;
        obj3 = false;
        obj4 = false;
        obj5 = true;
        obj6 = false;
    }
    public void sixObj()
    {
        creatingObject = teamCards.teamTwoCards[2];
        Creating = true;
        borderOn();
        obj1 = false;
        obj2 = false;
        obj3 = false;
        obj4 = false;
        obj5 = false;
        obj6 = true;
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
