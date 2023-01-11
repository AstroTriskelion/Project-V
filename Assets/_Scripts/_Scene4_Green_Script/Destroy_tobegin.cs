using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_tobegin : MonoBehaviour
{
    AudioSource audioSource;
    public Final Trigger;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Trigger = GameObject.Find("Flame").GetComponent<Final>();
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
