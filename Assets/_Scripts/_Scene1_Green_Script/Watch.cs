using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Watch : AStateBehaviour
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
        if (grabTheLantern == true)
        {
            Debug.Log("Switch to Museum");
            SceneManager.LoadScene("Museum_João_V2", LoadSceneMode.Single);
        }
        return (int)ELanternIntroductionStates.Invalid;
    }

    public void OnAudioCompleted()
    {
        grabTheLantern = true;
    }
}
