using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAudio_6 : MonoBehaviour
{
    AudioSource audioSource;
    public WaitForGrabScene3Blue Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<WaitForGrabScene3Blue>();
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
