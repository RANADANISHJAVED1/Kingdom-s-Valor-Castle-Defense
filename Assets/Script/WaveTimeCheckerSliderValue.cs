using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveTimeCheckerSliderValue : MonoBehaviour
{
    public Slider waveSlider;
    public float maxValue;
    private void Start()
    {
        maxValue = PlayerPrefs.GetInt("firstWaveTime")+ PlayerPrefs.GetInt("secondWaveTime")+ PlayerPrefs.GetInt("thirdWaveTime")+(PlayerPrefs.GetInt("thirdWaveEnemyNumber")*0.2F)+40;
        waveSlider.maxValue = maxValue;
    }
    private void Update()
    {
        waveSlider.value = waveSlider.value + Time.deltaTime;
    }
}
