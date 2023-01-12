using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class WaitForGrabScene3Blue : AStateBehaviour
{
    public bool grabTheLantern = false;
    public bool repeat = false;
    public SpawnAudioPrefabs SpawnAudio;
    public Animator openDoor;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {
        return true;
        openDoor = GetComponent<Animator>();
    }

    public override void OnStateStart()
    {
        Debug.Log("Find it");
        SpawnAudio.spawnAudioPrefab(0, true);
        SpawnAudio.spawnAudioPrefab(1);
        openDoor.SetBool("OpenDoor",true);
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
            Debug.Log("Switch to green 3");
            SceneManager.LoadScene("Stadium_João", LoadSceneMode.Single);
        }
        return (int)ELanternIntroductionStates.Invalid;
    }
    public void GrabedTheLantern()
    {
        if (repeat == false)
        {
            grabTheLantern = true;
            Debug.Log("You found it");       
            repeat = true;
        }
        return;
    }

    public void OnAudioCompleted()
    {
        grabTheLantern = true;
    }
}