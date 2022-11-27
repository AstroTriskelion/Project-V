using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DestroyNoAudio_1 : MonoBehaviour
{
    AudioSource audioSource;
    public WaitForGrab2 Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<WaitForGrab2>();
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
