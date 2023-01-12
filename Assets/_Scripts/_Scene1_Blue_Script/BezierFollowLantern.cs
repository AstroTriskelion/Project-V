using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierFollowLantern : MonoBehaviour
{
    [SerializeField] private Transform initialPosition;
    [SerializeField] private Transform tangentPosition;
    [SerializeField] private Transform tangentPosition2;
    [SerializeField] private Transform endPosition;

    [SerializeField] private Transform objectToMove;

    [SerializeField] private float Duration = 1.0f;
    [SerializeField] private float Duration2 = 1.0f;
    private float Timer = 0.0f;
    private float Timer2 = 0.0f;


    void Start()
    {
        
    }

    ///////////////////////////////////////////////////
    void Update()
    {
        if (Timer < Duration) //> <=
        {
            objectToMove.position = EvaluatePosition(Timer / Duration);
            Timer += Time.deltaTime;
            if (Timer >= Duration)
            {
                Timer2 = 0.0f;
            }

        }
        else
        {
            objectToMove.position = EvaluatePosition2(Timer2 / Duration2);
            Timer2 += Time.deltaTime;
            if (Timer2 >= Duration2)
            {
                Timer = 0.0f;
            }
        }
    }


    ///////////////////////////////////////////////////
    ///
    private Vector3 EvaluatePosition(float normalizedTime)
    {
        return (tangentPosition.position) +
            (Mathf.Pow(1 - normalizedTime, 2) * (initialPosition.position - tangentPosition.position)) +
            (Mathf.Pow(normalizedTime, 2) * (endPosition.position - tangentPosition.position));
    }

    private Vector3 EvaluatePosition2(float normalizedTime)
    {
        return (tangentPosition2.position) +
        (Mathf.Pow(1 - normalizedTime, 2) * (endPosition.position - tangentPosition2.position)) +
        (Mathf.Pow(normalizedTime, 2) * (initialPosition.position - tangentPosition2.position));
    }
}
