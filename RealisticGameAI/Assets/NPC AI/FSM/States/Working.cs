using System.Collections;
using System.Collections.Generic;

public class Working : State
{

    public Working () : base ("Working") { }

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
