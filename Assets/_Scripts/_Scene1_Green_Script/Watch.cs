using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : AStateBehaviour
{
    public SpawnAudioPrefabs SpawnAudio;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {
        return true;
    }

    public override void OnStateStart()
    {
        Debug.Log("Grab it");
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
