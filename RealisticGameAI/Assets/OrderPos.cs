using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderPos : Destination
{
    public void OnTriggerEnter (Collider collider)
    {
        if (collider.tag == "NPC") {
            NPCController controller = collider.GetComponent<NPCController>();
            controller.npc.stateMachine.changeState(StateMachine.idle);
        } 
    }
}
