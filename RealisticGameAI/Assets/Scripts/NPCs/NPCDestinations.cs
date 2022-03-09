using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestinations : MonoBehaviour
{
    NPC npc;

    public House house;
    public WorkPlace workPlace;

    void Awake () {
        npc = GetComponent<NPC>();
    }

}
