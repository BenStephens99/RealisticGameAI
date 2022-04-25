using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingPos : MonoBehaviour
{
    public NPC npc;
    public bool occupied = false;

    public virtual void add(NPC n) {
        npc = n;
        occupied = true;
        npc.workPos = this;
    }
}
 