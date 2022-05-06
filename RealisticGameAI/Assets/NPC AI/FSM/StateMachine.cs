using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{   
    public NPC me;
    public State currentState;
    public State previousState;

    public static Idle idle;
    public static Moving moving;
    public static Working working;
    public static Interacting interacting;

    public StateMachine (NPC npc) {
        moving = new Moving();
        idle = new Idle();
        working = new Working();
        interacting = new Interacting();
        me = npc;
    }

    public void Start () {
        previousState = idle;
        currentState = idle;
        currentState.Enter(me);
    }

    public void Update () {
        if (currentState != null) {
            currentState.UpdateLogic(me);
        }
    }

    public void LateUpdate() {
         if (currentState != null) {
            currentState.UpdatePhysics(me);
        }
    }

    public void onCollision (NPC npc) {
        if (currentState != null) {
            currentState.OnCollision(me, npc);
        }
    }

    public void changeState (State newState) {
        currentState.Exit(me);
        if (currentState.stateName != "Interacting") {
            previousState = currentState;
        }
        currentState = newState;
        currentState.Enter(me);
    }


}


