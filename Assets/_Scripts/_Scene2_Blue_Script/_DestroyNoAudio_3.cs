using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DestroyNoAudio_3 : MonoBehaviour
{
    AudioSource audioSource;
    public WaitForGrabScene2Blue Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<WaitForGrabScene2Blue>();
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
