using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public bool occupied;
    public NPC npc;

    public void add(NPC n) {
        npc = n;
        occupied = true;
    }

    public void remove(NPC n) {
        npc = null;
        occupied = false;
    }
}
