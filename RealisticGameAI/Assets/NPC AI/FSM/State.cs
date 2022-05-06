using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class State 
{

    public State (string n) {
        stateName = n;
    }
    public string stateName;
    public virtual void Enter(NPC me) {
         me.UIText = this.stateName;
    }
    public virtual void UpdateLogic(NPC me) {}

    public virtual void UpdatePhysics(NPC me) {
       
    }
    public virtual void OnCollision(NPC me, NPC npc) {
        me.interactingWith = npc;
        me.stateMachine.changeState(StateMachine.interacting);
     }

    public virtual void Exit(NPC me) { 
    }

}
