using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBezierExample : MonoBehaviour
{
    [SerializeField] private Transform initialPosition;
    [SerializeField] private Transform tangentPosition;
    [SerializeField] private Transform endPosition;

    [SerializeField] private Transform objectToMove;

    [SerializeField] private float Duration = 1.0f;
    private float Timer = 0.0f;

    // Update is called once per frame
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
            (Mathf.Pow(1-normalizedTime, 2) * (initialPosition.position - tangentPosition.position))+
            (Mathf.Pow(normalizedTime, 2)* (endPosition.position - tangentPosition.position));
    }
}
