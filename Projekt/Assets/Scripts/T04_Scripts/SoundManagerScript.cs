using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip timeFlowSound, timeRanOutSound;
    static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        timeFlowSound = Resources.Load<AudioClip>("clock");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public static void PlaySound(string clip)
    {
        switch (clip){
            case "clock":
                audioSrc.PlayOneShot(timeFlowSound);
                break;
            case "NoTime":
                audioSrc.PlayOneShot(timeRanOutSound);
                break;

        }
    }
}
