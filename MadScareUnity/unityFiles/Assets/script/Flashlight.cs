using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Flashlight: MonoBehaviour {

    static public int batteryLevel;
    public Light lampe;
    public bool isOn;  
    public float timer;
    AudioSource audioSource;
    public AudioClip soundOn;
    public AudioClip soundOff;

    void Start()
    {
        lampe = GetComponent<Light>();
        audioSource = GetComponent<AudioSource>();
        //Flashlight.batteryLevel = 100;
        reduireBatterie();
        isOn = true;
    }

    void Update()
    {
        if (timer >= 0)
        {
            if (isOn)
            {
                timer -= Time.deltaTime;
            }
        }

        if (timer <= 0)
        {
            timer = 5;
            reduireBatterie();
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            lampe.enabled = !lampe.enabled;

            if (!isOn)
            {
                isOn = true;
                audioSource.PlayOneShot(soundOn, 1);
            } else
            {
                isOn = false;
                audioSource.PlayOneShot(soundOff, 1);
            }
        }

        if (batteryLevel == 0)
        {
            batteryLevel = 0;
            isOn = false;
            lampe.enabled = false;
        }
    }

    void reduireBatterie()
    {
        if (isOn && Flashlight.batteryLevel > 0)
        {
            Flashlight.batteryLevel -= 1;
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, Screen.height / 1.21f, Screen.width / 6.16f, Screen.height / 19.58f), Flashlight.batteryLevel.ToString());
    }
}
