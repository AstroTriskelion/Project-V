using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternInitialSearchState : AStateBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform lanternTransform;
    
    // Please make me work through the AudioManager
    //[SerializeField] private AudioSource source;

    public override bool InitializeState()
    {
        if (!cameraTransform || !lanternTransform)
            return false;
        return true;
    }

    public override void OnStateStart()
    {
        //source.Play();
       
    }

    public override void OnStateUpdate()
    {}

    public override void OnStateEnd()
    {}

    public override int StateTransitionCondition()
    {
        if (IsPlayerLookingAtLantern())
        {
            Debug.Log("Found the lantern");
            return (int)ELanternIntroductionStates.Appear;
        }

        return (int)ELanternIntroductionStates.Invalid;
    }

    private bool IsPlayerLookingAtLantern()
    {
        Vector3 cameraForward = cameraTransform.forward;
        Vector3 directionToLantern = (lanternTransform.position - cameraTransform.position).normalized;
        
        return Vector3.Dot(cameraForward, directionToLantern) > 0.5f;
    }
}
