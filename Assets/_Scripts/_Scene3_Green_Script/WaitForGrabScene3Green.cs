using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class WaitForGrabScene3Green : AStateBehaviour
{
    public bool AudioFinished = false;
    public SpawnAudioPrefabs SpawnAudio;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {
        return true;
    }

    public override void OnStateStart()
    {
        Debug.Log("Listen");
        SpawnAudio.spawnAudioPrefab(0, true);
        SpawnAudio.spawnAudioPrefab(1, true);
        SpawnAudio.spawnAudioPrefab(2);
    }

    public override void OnStateUpdate()
    {
    }

    public override void OnStateEnd()
    {

    }

    public override int StateTransitionCondition()
    {
        if (AudioFinished == true)
        {
            Debug.Log("Next state");
            return (int)StadiumStates.LookForBooks;
        }
        return (int)ELanternIntroductionStates.Invalid;
    }

    public void OnAudioCompleted()
    {
        AudioFinished = true;
    }
}