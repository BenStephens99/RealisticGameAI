using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Idle() : base("Idle") {}

    public override void Enter(NPC npc)
    {
       base.Enter(npc);
      
    }
    public override void UpdateLogic(NPC me)
    {
        
        base.UpdateLogic(me);
    
      if (me.job != null) {
  
            if (me.job.startTime.hour == TimeDate.time.hour + 1) {
                me.nextDestination = me.workPos;
                me.stateMachine.changeState(StateMachine.moving);
            }
        } 
    }
    
    
    public override void Exit(NPC npc)
    {
        base.Exit(npc);
    }


}
