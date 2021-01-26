using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundOptions : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void Volume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
