using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DestroyNoAudio_2 : MonoBehaviour
{
    AudioSource audioSource;
    public Watch Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<Watch>();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            Trigger.OnAudioCompleted();
            Destroy(gameObject);
        }
    }
}