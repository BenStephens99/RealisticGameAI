using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State 
{

    public State (string n) {
        n = stateName;
    }

    public string stateName;
    public virtual void Enter(NPC npc) { Debug.Log("Enter " + this); }
    public virtual void UpdateLogic(NPC npc) {}
    public virtual void UpdatePhysics(NPC npc) {}
    public virtual void Exit(NPC npc) {Debug.Log("Exit " + this); }

}
