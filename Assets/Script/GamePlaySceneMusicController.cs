using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySceneMusicController : MonoBehaviour
{
    public AudioSource bgmusic;
    public AudioSource touchSound;
    // Start is called before the first frame update
    void Start()
    {
        bgmusic.volume = PlayerPrefs.GetFloat("VOLUMN");
    }
    public void touchSoundPlay()
    {
        touchSound.PlayOneShot(touchSound.clip);
    }    
}
