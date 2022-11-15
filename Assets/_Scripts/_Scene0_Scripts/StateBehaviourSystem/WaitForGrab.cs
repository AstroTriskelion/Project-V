using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForGrab : AStateBehaviour  //MonoBehaviour //
{

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
        return (int)ELanternIntroductionStates.Invalid;
    }

}