using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayCameraShifter : MonoBehaviour
{
    public Animator MainCameraAnimator;
    public bool first;
    private void Start()
    {
        first = true;
    }
    public void cameraAngeleChanger()
    {
        if (first)
        {
            MainCameraAnimator.SetTrigger("Second");
            first = false;
        }
        else if (!first)
        {
            MainCameraAnimator.SetTrigger("First");
            first = true;
        }
    }

}
