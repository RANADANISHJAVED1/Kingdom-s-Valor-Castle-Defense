using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsController : MonoBehaviour
{
    [SerializeField] int fps = 60;
    private void Start()
    {
    Application.targetFrameRate = fps;
    }
}
