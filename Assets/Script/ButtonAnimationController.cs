using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationController : MonoBehaviour
{
    public Animator MainMenuCameraAnimationController;
    public Animator CanvasAnimationController;
    public void PlayButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("Forward");
        CanvasAnimationController.SetTrigger("PlayForward");
        
    }
    public void teamSelectionCancleButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("Reverse");
        CanvasAnimationController.SetTrigger("BacwardlTeamSelection");
    }
    public void levelSelectionCancleButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("Reverse");
        CanvasAnimationController.SetTrigger("BackwardPlay");
    }
    public void levelSelectionForward()
    {
        CanvasAnimationController.SetTrigger("ForwardTeamSelection");
    }
    public void settingButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("SettingForward");
        CanvasAnimationController.SetTrigger("SettingForward");
    }
    public void SettingCancleButtonClicked()
    {
        MainMenuCameraAnimationController.SetTrigger("SettingBackward");
        CanvasAnimationController.SetTrigger("BackwardSetting");
    }
}
