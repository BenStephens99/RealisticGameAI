using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class State 
{
    [DllImport("Engine.dll")]
    [return: MarshalAs(UnmanagedType.BStr)]
    static extern string aprroached(Info npc, string state);

    public State (string n) {
        n = stateName;
    }

    public string stateName;
    public virtual void Enter(NPC me) {}
    public virtual void UpdateLogic(NPC me) {}
    public virtual void UpdatePhysics(NPC me) {}
    public virtual void OnCollision(NPC me, NPC npc) {
       // Debug.Log(aprroached(npc.memory.get(npc.idNumber), this.stateName));
     }
    public virtual void Exit(NPC me) { }

}
