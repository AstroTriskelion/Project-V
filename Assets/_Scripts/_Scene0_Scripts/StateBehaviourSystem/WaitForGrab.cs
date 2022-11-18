using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WaitForGrab : AStateBehaviour  //MonoBehaviour //
{
    public bool grabTheLantern = false;
    public TriggerAudioEvent triggerAudioEventScript;
   
    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {

        return true;
    }

    public override void OnStateStart()
    {
        Debug.Log("Grab it");
    }

    public override void OnStateUpdate()
    {
        
    }

    public override void OnStateEnd()
    {

    }

    public override int StateTransitionCondition()
    {
        if(grabTheLantern == true)
        {
            SceneManager.LoadScene("IndoorField_Juliette", LoadSceneMode.Single);
        }
        return (int)ELanternIntroductionStates.Invalid;
    }
    public void GrabedTheLantern()
    {
        //grabTheLantern = true;
        triggerAudioEventScript.RequestAudio();
        triggerAudioEventScript.OnAudioFinished += OnAudioCompleted;
        Debug.Log("You grabbed it");
        return;
    }

    public void OnAudioCompleted()
    {
        grabTheLantern = true;
    }
}