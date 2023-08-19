using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationController : MonoBehaviour
{
    public Animator MainMenuCameraAnimationController;
    public Animator CanvasAnimationController;
    public void QuitApplication()
    {
        this.gameObject.GetComponent<SoundController>().clickedSoundPlay();
        Application.Quit();
    }
    public void PlayButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("Forward");
        CanvasAnimationController.SetTrigger("PlayForward");
        this.gameObject.GetComponent<SoundController>().clickedSoundPlay();
    }
    public void levelSelectionCancleButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("Reverse");
        CanvasAnimationController.SetTrigger("BackwardPlay");
        this.gameObject.GetComponent<SoundController>().clickedSoundPlay();
    }
    public void settingButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("SettingForward");
        CanvasAnimationController.SetTrigger("SettingForward");
        this.gameObject.GetComponent<SoundController>().settingClickedActive();
        this.gameObject.GetComponent<SoundController>().clickedSoundPlay();
       
    }
    public void SettingCancleButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("SettingBackward");
        CanvasAnimationController.SetTrigger("BackwardSetting");
        this.gameObject.GetComponent<SoundController>().settingClickedDeactive();
        this.gameObject.GetComponent<SoundController>().clickedSoundPlay();
    }
}
