using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Final : AStateBehaviour
{
    public SpawnAudioPrefabs SpawnAudio;
    public bool grabTheLantern = false;


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
       
        return (int)ELanternIntroductionStates.Invalid;
    }
}
