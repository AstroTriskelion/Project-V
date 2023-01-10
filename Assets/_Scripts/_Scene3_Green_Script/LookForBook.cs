using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class LookForBook : AStateBehaviour
{
    public bool grabTheLantern = false;
    public SpawnAudioPrefabs SpawnAudio;
    public GameObject Book;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {
        return true;
    }

    public override void OnStateStart()
    {
        Debug.Log("Find it");
        SpawnAudio.spawnAudioPrefab(3, true);
        MeshRenderer m = Book.GetComponent<MeshRenderer>();
        m.enabled = true;
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
            Debug.Log("Next state");
            SceneManager.LoadScene("SwimmingPool_backup", LoadSceneMode.Single);
        }
        return (int)ELanternIntroductionStates.Invalid;
    }

    public void GrabedTheLantern()
    {
        grabTheLantern = true;
        Debug.Log("You grabbed it");
        return;
    }
}
