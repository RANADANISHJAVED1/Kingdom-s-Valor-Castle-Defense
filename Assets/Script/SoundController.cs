using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public Slider soundController;
    public AudioSource backgroundAudio;
    public AudioSource clickSound;
    private bool clicked = false;

    void Start()
    {
        if (PlayerPrefs.HasKey("VOLUMN"))
        {
            backgroundAudio.volume = PlayerPrefs.GetFloat("VOLUMN");
            soundController.value = PlayerPrefs.GetFloat("VOLUMN");
        }
        else if (!PlayerPrefs.HasKey("VOLUMN"))
        {
            backgroundAudio.volume = 1;
            soundController.value = 1;
            PlayerPrefs.SetFloat("VOLUMN", 1);
        }
    }
    private void Update()
    {
        if (clicked)
        {
            backgroundAudio.volume = soundController.value;
        }
    }
    public void settingClickedActive()
    {
        clicked = true;
    }
    public void settingClickedDeactive()
    {
        clicked = false;
        PlayerPrefs.SetFloat("VOLUMN", soundController.value);
    }
    public void clickedSoundPlay()
    {
            clickSound.PlayOneShot(clickSound.clip);
    }
    
}
