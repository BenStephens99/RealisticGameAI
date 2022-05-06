using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Moving : State
{   

    public Moving () : base ("Moving") { }

    public bool arrived;
    public override void Enter(NPC me)
    {
        base.Enter(me);
        NPCActions.go(me);
    }
    public override void UpdatePhysics(NPC me)
    {
        base.UpdatePhysics(me);
    }

    public override void UpdateLogic(NPC me)
    {    
        base.UpdateLogic(me); 
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
