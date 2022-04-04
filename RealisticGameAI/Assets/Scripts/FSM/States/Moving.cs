using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : State
{

    public Moving () : base ("Moving") { }

    public override void Enter(NPC npc)
    {
        base.Enter(npc);
        npc.controller.go();

    }
    public override void UpdatePhysics(NPC npc)
    {
        base.UpdatePhysics(npc);
    }

    public override void UpdateLogic(NPC npc)
    {
        base.UpdateLogic(npc);
        if (npc.transform.position.x == npc.controller.destination.x) {
            if (npc.transform.position.z == npc.controller.destination.z) {
                  npc.stateMachine.changeState (StateMachine.idle);
            }
        }
    }

    public override void Exit(NPC npc)
    {
        base.Exit(npc);
       
    }


}
