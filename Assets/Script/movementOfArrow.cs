using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementOfArrow : MonoBehaviour
{
    public int length = 7;
    public int speed = 3;
    public Vector3 initialPosition;
    void Start()
    {
        initialPosition=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up* speed * Time.deltaTime);
        if (this.transform.position.x - initialPosition.x > length)
        {
            Destroy(this.gameObject);
        }
    }
}
