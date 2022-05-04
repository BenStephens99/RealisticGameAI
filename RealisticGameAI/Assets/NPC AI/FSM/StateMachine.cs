using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{   
    public NPC me;
    public State currentState;
    public static Idle idle;
    public static Moving moving;
    public static Working working;

    public StateMachine (NPC npc) {
        moving = new Moving();
        idle = new Idle();
        working = new Working();
        currentState = idle;
        me = npc;
    }

    public void Start () {
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
        currentState = newState;
        currentState.Enter(me);
    }


}


