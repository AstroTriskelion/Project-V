using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNoAudio_5 : MonoBehaviour
{
    AudioSource audioSource;
    public WaitForGrabScene3Green Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<WaitForGrabScene3Green>();
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
