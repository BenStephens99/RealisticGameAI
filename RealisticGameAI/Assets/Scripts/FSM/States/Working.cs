using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Working : State
{

    public Working () : base ("Working") { }

    public override void Enter(NPC npc)
    {
        base.Enter(npc);
        npc.controller.destination = npc.workPos.transform.position;
        npc.controller.go();

    }
    public override void UpdatePhysics(NPC me)
    {
        base.UpdatePhysics(me);
    }

    public override void UpdateLogic(NPC me)
    {
        base.UpdateLogic(me);

        if (TimeDate.time.hour == me.job.startTime.hour && TimeDate.time.minute == me.job.startTime.minute) {
            me.stateMachine.changeState(StateMachine.idle);
        }

    }

    public override void OnCollision(NPC me, NPC npc)
    {
        base.OnCollision(me, npc);
    }

    public override void Exit(NPC me)
    {
        base.Exit(me);
       
    }


}
