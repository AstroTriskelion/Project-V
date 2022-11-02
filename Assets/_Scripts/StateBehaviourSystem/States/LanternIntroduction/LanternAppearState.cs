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

    [SerializeField] private PlayableDirector director;

    public override bool InitializeState()
    {
        if (!director)
            return false;

        director.stopped += OnDirectorFinished;

        return true;
    }

    public override void OnStateStart()
    {
        director.Play();
    }

    public override void OnStateUpdate()
    {}

    public override void OnStateEnd()
    {}

    public override int StateTransitionCondition()
    {
        return (int)ELanternIntroductionStates.Invalid;
    }

    private void OnDirectorFinished(PlayableDirector director) 
    {
        AssociatedStateMachine.SetState((int)ELanternIntroductionStates.BezierMove);
    }
}
