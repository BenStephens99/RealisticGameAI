using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class State 
{
[DllImport("Engine.dll")]
[return: MarshalAs(UnmanagedType.BStr)]
private static extern string walkPast(int id);

[DllImport("Engine.dll")]
private static extern void updateState(string s);
    public State (string n) {
        n = stateName;
    }

    public string stateName;
    public virtual void Enter(NPC me) { 
        updateState(this.stateName);
    }
    public virtual void UpdateLogic(NPC me) {}
    public virtual void UpdatePhysics(NPC me) {}
    public virtual void OnCollision(NPC me, NPC npc) {
        string output = walkPast(npc.idNumber);
        Debug.Log("Output " + output);
        switch (output) {
            case "continue":
            return;

            case "Begin Conversation":
            me.interact(npc);
            break;

            default: 
            Debug.Log(output);
            break;
        } 
    }
    public virtual void Exit(NPC me) { }

}
