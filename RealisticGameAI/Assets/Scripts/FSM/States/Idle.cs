using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Idle() : base("Idle") {}

    public override void Enter(NPC npc)
    {
       base.Enter(npc);
       npc.controller.stop();
    }

    public override void UpdateLogic(NPC me)
    {
        base.UpdateLogic(me);
    
        if (me.job.days[TimeDate.dayCounter] == 1) {
            if (TimeDate.time.hour == me.job.startTime.hour && (TimeDate.time.minute == me.job.startTime.minute + 30)) {
             me.stateMachine.changeState(StateMachine.working);
            }   else if (TimeDate.time.hour == me.job.startTime.hour - 1 && (TimeDate.time.minute + 30) == me.job.startTime.minute) {
                me.stateMachine.changeState(StateMachine.working);
            }
        }
    }

    public override void Exit(NPC npc)
    {
        base.Exit(npc);
    }


}
