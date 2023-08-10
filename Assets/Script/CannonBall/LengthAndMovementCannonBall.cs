using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengthAndMovementCannonBall : MonoBehaviour
{
    [HideInInspector]
    public int length;
    [HideInInspector]
    public int speed;
    private Vector3 instanciatePosition;
    public GameObject fireObj;
    public GameObject fireOnBallObj;
    public ParticleSystem fire;
    public ParticleSystem fireOnBall;
    private void Start()
    {
        fireOnBallObj.SetActive(false);
        StartCoroutine(fireOnBallFun());
        instanciatePosition = this.transform.position;
        fireObj.SetActive(false);
    }
   /* private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("ENEMY") || other.gameObject.CompareTag("EnemyDestroy"))
            {
                Destroy(other.gameObject);
                speed = 0;
                fireObj.SetActive(true);
                fire.Play();
                StartCoroutine(fireController());
            }
    }*/
    private void FixedUpdate()
    {
        fireOnBall.transform.position = this.transform.position;
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        /*if (transform.position.x - instanciatePosition.x >= length)
        {
            Destroy(this.gameObject);
        }*/
    }
    IEnumerator fireOnBallFun()
    {
        yield return new WaitForSeconds(0.2f);
        fireOnBallObj.SetActive(true);
        fireOnBall.Play();
    }
    IEnumerator fireController()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
