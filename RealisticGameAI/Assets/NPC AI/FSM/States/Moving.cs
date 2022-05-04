using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Moving : State
{   

    public Moving () : base ("Moving") { }

    public override void Enter(NPC me)
    {
        base.Enter(me);
        me.go();
    }
    public override void UpdatePhysics(NPC me)
    {
        base.UpdatePhysics(me);
    }

    public override void UpdateLogic(NPC me)
    {    
        base.UpdateLogic(me);
        if (me.nextDestination.transform.position == me.controller.transform.position) {
           if (me.nextDestination is WorkingPos) {
               me.stateMachine.changeState(StateMachine.working);
           } else {
               me.stateMachine.changeState(StateMachine.idle);
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
