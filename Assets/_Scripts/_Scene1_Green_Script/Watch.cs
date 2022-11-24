using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : AStateBehaviour
{
    public TriggerAudioEvent triggerAudioEventScript;
    //public SpawnAudioPrefabs SpawnAudio;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {

        return true;
    }

    public override void OnStateStart()
    {
        Debug.Log("Grab it");
        triggerAudioEventScript.RequestAudio();
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
