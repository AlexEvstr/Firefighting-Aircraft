using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public GameObject On;
    public GameObject Off;

    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("audio", 1);
        if (AudioListener.volume == 1)
        {
            SoundsOn();
        }
        else
        {
            SoundsOff();
        }
    }

    public void SoundsOff()
    {
        On.SetActive(false);
        Off.SetActive(true);
        AudioListener.volume = 0;
        PlayerPrefs.SetFloat("audio", AudioListener.volume);
    }

    public void SoundsOn()
    {
        On.SetActive(true);
        Off.SetActive(false);
        AudioListener.volume = 1;
        PlayerPrefs.SetFloat("audio", AudioListener.volume);
    }
}
