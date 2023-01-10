using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DestroyNoAudio_4 : MonoBehaviour
{
    AudioSource audioSource;
    public WaitingForGrabScene2Green Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<WaitingForGrabScene2Green>();
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
