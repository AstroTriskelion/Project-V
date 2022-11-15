using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : AStateBehaviour  //MonoBehaviour //
{
    //public Vector3 positionToMoveTo;
    
    [SerializeField]private GameObject start;
    [SerializeField]private GameObject end;
    float timer = 0;
    bool CanTransition = true;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {

        return true;
    }

    public override void OnStateStart()
    {
        Debug.Log("Soul starts moving");
    }


    public override void OnStateUpdate()
    {
        if (!CanTransition)
            return;

        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(start.transform.position, end.transform.position, timer);
    }

    public override void OnStateEnd()
    {

    }

    public override int StateTransitionCondition()
    {
        if(transform.position == end.transform.position)
        {
            Debug.Log("Pass to Bezier");
            return (int)ELanternIntroductionStates.BezierMove;
        }
        return (int)ELanternIntroductionStates.Invalid;
    }
}