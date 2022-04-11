using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public List<NPC> npcs;
    public Chair[] chairs;
    public int max;
    public int current;

    void Awake () {
        chairs = GetComponentsInChildren<Chair>();
        max = chairs.Length;
    }
    public void add(NPC npc) {
        if (current < max) {
            npcs.Add(npc);
            current++;
        } else {
            Debug.Log("Table Full");
        }
    }

    public void remove(NPC npc){
        npcs.Remove(npc);
        current--;
    }

}
