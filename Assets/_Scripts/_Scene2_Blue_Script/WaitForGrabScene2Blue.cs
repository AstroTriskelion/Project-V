using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class WaitForGrabScene2Blue : AStateBehaviour
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
        SpawnAudio.spawnAudioPrefab(0, true);
        SpawnAudio.spawnAudioPrefab(1, true);
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
            Debug.Log("Switch to green 2");
            SceneManager.LoadScene("IndoorField_BaskteballJuliette", LoadSceneMode.Single);
        }
        return (int)ELanternIntroductionStates.Invalid;
    }
    public void GrabedTheLantern()
    {
        if (repeat == false)
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