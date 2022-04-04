using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{   
    public NPC npc;
    public State currentState;
    public static Idle idle;
    public static Moving moving;

    void Awake () {
        moving = new Moving();
        idle = new Idle();
    }

    void Start () {
        currentState = idle;
        currentState.Enter(npc);
    }

    void Update () {
        if (currentState != null) {
            currentState.UpdateLogic(npc);
        }
    }

    void LateUpdate() {
         if (currentState != null) {
            currentState.UpdatePhysics(npc);
        }
    }

    public void changeState (State newState) {
        currentState.Exit(npc);
        currentState = newState;
        currentState.Enter(npc);
        npc.state = currentState.stateName;
    }
}


