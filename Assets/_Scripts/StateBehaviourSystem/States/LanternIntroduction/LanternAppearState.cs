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
    [SerializeField] private float Duration = 1.0f;
    private float Timer = 0.0f;
    private bool next = false;

    public override bool InitializeState()
    {
        /* if (!director)
             return false;
        director.stopped += OnDirectorFinished;*/

        var cubeRenderer = Lamp.GetComponent<Renderer>().material;
        Color color = cubeRenderer.color;
        color.a = 0f;
        cubeRenderer.color = color;
        return true;

        
    }

    public override void OnStateStart()
    {
        /*var cubeRenderer = Lamp.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.red);*/
        // director.Play();
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
            Debug.Log("Not done with Lamp");
            TickDown(Timer / Duration);
            Timer += Time.deltaTime;
            if(Timer >= Duration)
            {
                next = true;
            }
        }
    }

    public override void OnStateEnd()
    {}

    public override int StateTransitionCondition()
    {
        /*if (Timer / Duration == 1f)
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

    private void TickDown(float normalizedTime)
    {
        var cubeRenderer = Lamp.GetComponent<Renderer>().material;
        Color color = cubeRenderer.color;
        color.a = normalizedTime;
        cubeRenderer.color = color;
        return;
    }
}
