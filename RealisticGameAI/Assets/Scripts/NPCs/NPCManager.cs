using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public int numOfNpcs = 5;

    public NPC npc;
    public List<NPC> npcs = new List<NPC> ();

    public void init () {
        createNPCs(numOfNpcs); 
        assignRandomJobs();
    }

    public void createNPCs(int num)
    {
         for (int v = 0; v <= (num - 1); v++) {
            npcs.Add(Instantiate(npc));
        }
    }

    public void assignRandomJobs() {
            
         foreach (NPC npc in npcs) {
            Job.AssignRandomJob(npc);
        }
    }


}

