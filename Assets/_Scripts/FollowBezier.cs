using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBezier : AStateBehaviour  //MonoBehaviour //
{
    [SerializeField] private Transform initialPosition;
    [SerializeField] private Transform tangentPosition;
    [SerializeField] private Transform tangentPosition2;
    [SerializeField] private Transform endPosition;

    [SerializeField] private Transform objectToMove;

    [SerializeField] private float Duration = 1.0f;
    //[SerializeField] private float Duration2 = 4.0f;
    private float Timer = 0.0f;
    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool InitializeState()
    {
        //objectToMove.position = EvaluatePosition(Timer / Duration);
        Debug.Log("On");
        return true;
    }

    public override void OnStateStart()
    {
      
    }

    public override void OnStateUpdate()
    {
        Debug.Log("Timer Start");
        Timer += Time.deltaTime;
        if (Timer > Duration)
            Timer = 0;

        Debug.Log("Bezier animation");
        objectToMove.position = EvaluatePosition(Timer / Duration);

        //if (Timer > Duration2)
        //    Timer = 0;
        //objectToMove.position = EvaluatePosition2(Timer / Duration2);
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
    }

    private Vector3 EvaluatePosition2(float normalizedTime)
    {
        //return (Mathf.Pow(1-normalizedTime, 2)* initialPosition.position) + 
        //    (2 * (1-normalizedTime) * normalizedTime * tangentPosition.position) + 
        //    (Mathf.Pow(normalizedTime ,2 ) * (endPosition.position - tangentPosition.position));

        return (tangentPosition2.position) +
            (Mathf.Pow(1 - normalizedTime, 2) * (initialPosition.position - tangentPosition2.position)) +
            (Mathf.Pow(normalizedTime, 2) * (endPosition.position - tangentPosition2.position));
    }
}

/*void Update()
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
    }*/

