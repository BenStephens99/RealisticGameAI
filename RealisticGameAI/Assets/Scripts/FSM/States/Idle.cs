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

    public override void Exit(NPC npc)
    {
        base.Exit(npc);
    }


}
