using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Idle() : base("Idle") {}
    gameTime timeEntered;
    bool workingDay;
    public override void Enter(NPC me)
    {
       base.Enter(me);
       timeEntered = TimeDate.time;

       if (me.job != null) {
            if (me.job.days[TimeDate.dayCounter] == 1) { 
                workingDay = true;
            }
        } else {
            workingDay = false;
        }

  
    }   
    public override void UpdateLogic(NPC me)
    {
        base.UpdateLogic(me);
        if (workingDay) {
            if (me.job.startTime.hour -1 == TimeDate.time.hour) {
                NPCActions.goToWork(me);
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
