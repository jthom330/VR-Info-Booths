using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public AudioClip clip;
    public GvrAudioSource source;

    void Start()
    {
        source.clip = clip;
    }

    public void PlayAudio()
    {

        source.Stop();
        source.Play();
    }
}
