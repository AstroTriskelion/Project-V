using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WaitForGrab : AStateBehaviour  //MonoBehaviour //
{
    public bool grabTheLantern = false;
    public bool repeat = false;
    public SpawnAudioPrefabs SpawnAudio;

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
        if (Input.GetKeyDown("space"))
        {
            GrabedTheLantern();
        }
    }

    public override void OnStateEnd()
    {

    }

    public override int StateTransitionCondition()
    {
        if(grabTheLantern == true)
        {
            SceneManager.LoadScene("Intro_Juliette", LoadSceneMode.Single);
        }
        return (int)ELanternIntroductionStates.Invalid;
    }
    public void GrabedTheLantern()
    {
        //grabTheLantern = true;
        //triggerAudioEventScript.RequestAudio();
        //triggerAudioEventScript.OnAudioFinished += OnAudioCompleted;
        if(repeat == false)
        {
            SpawnAudio.spawnAudioPrefab(2, true);
            Debug.Log("You grabbed it");
            repeat = true;
        }
        
        return;
    }

    public void OnAudioCompleted()
    {
        grabTheLantern = true;
    }
}