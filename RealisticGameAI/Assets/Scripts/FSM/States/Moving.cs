using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;



public class Moving : State
{
    
[DllImport("Engine.dll")]
[return: MarshalAs(UnmanagedType.BStr)]
private static extern string walkPast(int id);

    public Moving () : base ("Moving") { }

    public override void Enter(NPC me)
    {
        base.Enter(me);
        me.controller.go();

    }
    public override void UpdatePhysics(NPC me)
    {
        base.UpdatePhysics(me);
    }

    public override void UpdateLogic(NPC me)
    {
        base.UpdateLogic(me);
        if (me.transform.position.x == me.controller.destination.x) {
            if (me.transform.position.z == me.controller.destination.z) {
                  me.stateMachine.changeState (StateMachine.idle);
            }
        }
    }

    public override void OnCollision(NPC me, NPC npc)
    {
        base.OnCollision(me, npc);
        
    }

    public override void Exit(NPC npc)
    {
        base.Exit(npc);
       
    }


}
