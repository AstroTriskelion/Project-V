using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Use this file to declare all your states for a given enumeration or statemachine

// Dont delete me im used in the example!
public enum EMonsterState
{
    Invalid = -1,
    Idle,
    Patrolling,
    Chasing,
}

public enum ELanternIntroductionStates
{
    Invalid = -1,
    InitialSearch,
    Appear,
    MoveToPos,
    BezierMove,
    MoveToLantern,
    WaitForGrab,
    Narrative,
    FlashTransition
}

public enum StadiumStates
{
    Invalid = -1,
    WaitForGrabScene3Green,
    LookForBooks
}