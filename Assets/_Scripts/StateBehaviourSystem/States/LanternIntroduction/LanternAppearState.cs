using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LanternAppearState : AStateBehaviour
{
    //[SerializeField] private Transform lanterTransform;
    //[SerializeField] private Light lightBelow;
    //[SerializeField] private Light flameLight;
    //[SerializeField] private Animator animations;

    //[SerializeField] private PlayableDirector director;
    //[SerializeField] private Material Lantern;
    [SerializeField] private GameObject Lamp;
    //int i = 0;

    public override bool InitializeState()
    {
        /* if (!director)
             return false;

         director.stopped += OnDirectorFinished;*/
        return true; 
    }

    public override void OnStateStart()
    {
        var cubeRenderer = Lamp.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.red);
        //i = 1;

        Debug.Log("Color Changed");

        OnDirectorFinished();
        // director.Play();
    }

    public override void OnStateUpdate()
    {        
    }

    public override void OnStateEnd()
    {}

    public override int StateTransitionCondition()
    {
        /*if (i == 1 )
        {
            Debug.Log("Bazier time");
            return (int)ELanternIntroductionStates.BezierMove;
        }*/
        return (int)ELanternIntroductionStates.Invalid;
    }

    private void OnDirectorFinished() //PlayableDirector director
    {
        Debug.Log("Bazier time");
        AssociatedStateMachine.SetState((int)ELanternIntroductionStates.BezierMove);
    }
}
