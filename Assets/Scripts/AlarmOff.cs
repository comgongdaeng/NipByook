using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AlarmOff : MonoBehaviour
{
    public void AudioVolumeZero(){
        AudioListener.volume = 0;
    }
}
