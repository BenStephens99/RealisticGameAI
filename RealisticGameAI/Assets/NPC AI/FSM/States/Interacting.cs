using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
public class Interacting : State
{

    [DllImport("Engine.dll")]
    [return: MarshalAs(UnmanagedType.BStr)]
    static extern string aprroached(Info npcNode, string state);
    public Interacting () : base ("Interacting") { }
    int timeToEnd;

    public override void Enter(NPC me)
    {
        base.Enter(me);
        Memory.npcNode node = me.memory.get(me.interactingWith.idNumber);
        Info info;
        info.name = node.name;
        info.relationship = node.relationship;

        NPCActions.decide(me, aprroached(info, stateName));
        timeToEnd = TimeDate.time.minute + 5;
    }   
    
    public override void UpdateLogic(NPC me)
    {
        base.UpdateLogic(me);
        if (timeToEnd == TimeDate.time.minute) {
            if (me.stateMachine.previousState != null) {
                me.stateMachine.changeState(me.stateMachine.previousState);
            } else {
                me.stateMachine.changeState(StateMachine.idle);
            }
        }
    }

    public override void UpdatePhysics(NPC me)
    {
        base.UpdatePhysics(me);
    }
    
    public override void OnCollision(NPC me, NPC npc)
    {
    }

    public override void Exit(NPC me)
    {
        base.Exit(me);
        NPCActions.go(me);
    }


}
