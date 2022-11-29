using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class WaitForGrab2 : AStateBehaviour
{
    public bool grabTheLantern = false;
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
        SpawnAudio.spawnAudioPrefab(2, true);
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
        if (grabTheLantern == true)
        {
            Debug.Log("Switch to green");
            SceneManager.LoadScene("IndoorField_Juliette", LoadSceneMode.Single);
        }
        return (int)ELanternIntroductionStates.Invalid;
    }
    public void GrabedTheLantern()
    {
        SpawnAudio.spawnAudioPrefab(1, true);
        Debug.Log("You grabbed it");
        return;
    }

    public void OnAudioCompleted()
    {
        grabTheLantern = true;
    }
}

