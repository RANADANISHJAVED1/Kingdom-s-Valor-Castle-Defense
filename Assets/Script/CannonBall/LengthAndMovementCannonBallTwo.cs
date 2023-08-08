using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengthAndMovementCannonBallTwo : MonoBehaviour
{
    [HideInInspector]
    public int length;
    [HideInInspector]
    public float speed;
    private Vector3 instanciatePosition;
    private void Start()
    {
        instanciatePosition = this.transform.position;
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x - instanciatePosition.x >= length)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ENEMY"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("EnemyDestroy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
