using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public NPC npc;

    void Awake () {
        npc = new NPC (0);
        gameObject.tag = "Player";
    }
}

