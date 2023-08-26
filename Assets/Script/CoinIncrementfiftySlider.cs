using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinIncrementfiftySlider : MonoBehaviour
{
    public Slider coinIncreaseSlider;
    public GameObject coinIncreaseBtn;
    public bool triggedOneTime;
    AudioSource coinSound;
    private bool playSound;
    // Start is called before the first frame update
    private void Start()
    {
        playSound = false;
        coinIncreaseSlider.maxValue = 20;
        coinIncreaseSlider.value = 0;
        coinIncreaseBtn.SetActive(false);
        triggedOneTime = false;
        coinSound = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(coinIncreaseSlider.value == coinIncreaseSlider.maxValue)
        {
            coinIncreaseBtn.SetActive(true);
            if (!playSound)
            {
                coinSound.PlayOneShot(coinSound.clip);
                playSound = true;
            }
            if (!triggedOneTime)
            {
                this.gameObject.GetComponentInParent<Animator>().SetTrigger("CoinAnim");
                triggedOneTime = true;
            }
        }
        if (coinIncreaseSlider.value < coinIncreaseSlider.maxValue)
        {
            coinIncreaseSlider.value = coinIncreaseSlider.value + Time.deltaTime;
        }
    }
    public void coinBtnClick()
    {
        coinIncreaseSlider.value = 0;
        coinIncreaseBtn.SetActive(false);
        playSound = false;
        GameObject.Find("GameManager").GetComponent<GamePlaySceneMusicController>().touchSoundPlay();
        GameObject.Find("GameManager").GetComponent<SelectedTeamFeaturesActivator>().currencyDecrese(50);
    }
}
