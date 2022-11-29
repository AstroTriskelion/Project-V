using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LanternAppearState : AStateBehaviour
{
    [SerializeField] private GameObject SoulAlpha;
    [SerializeField] private GameObject SoulSparks;
    [SerializeField] private GameObject SoulLight;
    public SpawnAudioPrefabs SpawnAudio;
    private float Timer = 0.0f;
    private bool next = false;

    public override bool InitializeState()
    {
        return true; 
    }

    public override void OnStateStart()
    {
        // director.Play();
        SoulAlpha.GetComponent<Animator>().SetBool("Alpha_O", true);
        SoulSparks.GetComponent<Animator>().SetBool("Sparks_O", true);
        SoulLight.GetComponent<Animator>().SetBool("Light_O", true);
        SpawnAudio.spawnAudioPrefab(1, true);
    }

    public override void OnStateUpdate()//> <=
    {
        
        if (next == true)
        {
            Debug.Log("Done with Lamp");
            OnDirectorFinished();
        }
        else
        {
            //Debug.Log("Not done with Lamp");
            Timer += Time.deltaTime;
            if(Timer >= 6)
            {
                next = true;
            }
        }
    }

    public override void OnStateEnd()
    {}

    public override int StateTransitionCondition()
    {
        return (int)ELanternIntroductionStates.Invalid;
    }

    private void OnDirectorFinished() //PlayableDirector director
    {
        Debug.Log("Soul appeared");
        AssociatedStateMachine.SetState((int)ELanternIntroductionStates.MoveToPos);
    }
}
