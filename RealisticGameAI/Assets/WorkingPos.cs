using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingPos : Destination
{
    public NPC npc;
    public bool occupied = false;
    public virtual void add(NPC n) {
        npc = n;
        occupied = true;
        npc.workPos = this;
    }
    
    public void OnTriggerEnter (Collider collider)
    {
        if (collider.tag == "NPC") {
            NPCController controller = collider.GetComponent<NPCController>();
            if (controller.npc == npc) {
                controller.npc.stateMachine.changeState(StateMachine.working);
            }
            
        }
    }

}
 