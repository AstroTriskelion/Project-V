using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBezierExample : MonoBehaviour  //AStateBehaviour //
{
    [SerializeField] private Transform initialPosition;
    [SerializeField] private Transform tangentPosition;
    [SerializeField] private Transform endPosition;

    [SerializeField] private Transform objectToMove;

    [SerializeField] private float Duration = 1.0f;
    private float Timer = 0.0f;


    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > Duration)
            Timer = 0;

        objectToMove.position = EvaluatePosition(Timer / Duration);
    }

    private Vector3 EvaluatePosition(float normalizedTime)
    {
        //return (Mathf.Pow(1-normalizedTime, 2)* initialPosition.position) + 
        //    (2 * (1-normalizedTime) * normalizedTime * tangentPosition.position) + 
        //    (Mathf.Pow(normalizedTime ,2 ) * (endPosition.position - tangentPosition.position));

        return (tangentPosition.position) +
            (Mathf.Pow(1 - normalizedTime, 2) * (initialPosition.position - tangentPosition.position)) +
            (Mathf.Pow(normalizedTime, 2) * (endPosition.position - tangentPosition.position));
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////
    /*public override bool InitializeState()
    {
        Timer += Time.deltaTime;
        if (Timer > Duration)
            Timer = 0;
        return true;
        //objectToMove.position = EvaluatePosition(Timer / Duration);
    }

    public override void OnStateStart()
    {
       
    }

    public override void OnStateUpdate()
    {
        objectToMove.position = EvaluatePosition(Timer / Duration);
    }

    public override void OnStateEnd()
    {
    
    }

    public override int StateTransitionCondition()
    {
        //if (EvaluatePosition())
        //{
        //    return (int)ELanternIntroductionStates.WaitForGrab;
        //}

        return (int)ELanternIntroductionStates.Invalid;
    }

    private Vector3 EvaluatePosition(float normalizedTime)
    {
        //return (Mathf.Pow(1-normalizedTime, 2)* initialPosition.position) + 
        //    (2 * (1-normalizedTime) * normalizedTime * tangentPosition.position) + 
        //    (Mathf.Pow(normalizedTime ,2 ) * (endPosition.position - tangentPosition.position));

        return (tangentPosition.position) +
            (Mathf.Pow(1 - normalizedTime, 2) * (initialPosition.position - tangentPosition.position)) +
            (Mathf.Pow(normalizedTime, 2) * (endPosition.position - tangentPosition.position));
    }*/
}