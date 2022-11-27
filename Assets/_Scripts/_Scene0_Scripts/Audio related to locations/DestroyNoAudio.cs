using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNoAudio : MonoBehaviour
{
    AudioSource audioSource;
    public WaitForGrab Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<WaitForGrab>();
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
