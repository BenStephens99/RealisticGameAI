using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class State 
{

[DllImport("Engine.dll")]
private static extern void updateState(string s);

    public State (string n) {
        n = stateName;
    }

    public string stateName;
    public virtual void Enter(NPC me) { 
        //updateState(this.stateName);
        Debug.Log(me.fullName + " entered state " + this);
    }
    public virtual void UpdateLogic(NPC me) {}
    public virtual void UpdatePhysics(NPC me) {}
    public virtual void OnCollision(NPC me, NPC npc) { 

    }
    public virtual void Exit(NPC me) { }

}
