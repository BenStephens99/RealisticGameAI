using System.Collections;
using System.Collections.Generic;

public class NPCManager 
{
    public int numOfNpcs;
    public List<NPC> npcList = new List<NPC> ();

    public void init () {
        createNPCs(numOfNpcs); 
        assignRandomJobs();
    }

    public void createNPCs(int num)
    {
         for (int v = 0; v <= (num - 1); v++) {
            NPC newNPC = new NPC();
            npcList.Add(newNPC);
            newNPC.idNumber = v+1;
        }
    }

    public  void assignRandomJobs() {
         foreach (NPC npc in npcList) {
            JobManager.AssignRandomJob(npc);
        }
    }





}

