using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerParticularEffect : MonoBehaviour
{
    public GameObject smoke;
    public GameObject smallSmoke;
    public GameObject fireSmoke;
    public GameObject bloodBlast;
    public GameObject bloodBonesBlast;

    public void smokeInsFun(Vector3 pos)
    {
        Instantiate(smoke, pos, smoke.transform.rotation);
    }
    public void fireSmokeInsFun(Vector3 pos)
    {
        Instantiate(fireSmoke, pos, fireSmoke.transform.rotation);
    }
    public void smallSmokeInsFun(Vector3 pos)
    {
        Instantiate(smallSmoke,pos, smallSmoke.transform.rotation);
    }
    public void bloodExplision(Vector3 pos)
    {
        Instantiate(bloodBlast, pos, bloodBlast.transform.rotation);
    }
    public IEnumerator bloodBonesExplision(Vector3 pos)
    {
        yield return new WaitForSeconds(3);
        Instantiate(bloodBonesBlast, pos, bloodBonesBlast.transform.rotation);
    }
    public IEnumerator bloodBonesExplisionEnemy(Vector3 pos,GameObject enemyObj)
    {
        yield return new WaitForSeconds(3);
        Instantiate(bloodBonesBlast, pos, bloodBonesBlast.transform.rotation);
        Destroy(enemyObj);
    }
}
