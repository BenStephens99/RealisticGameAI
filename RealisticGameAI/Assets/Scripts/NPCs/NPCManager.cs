using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public int numOfNpcs;
    public NPC npcPrefab;
    public static List<NPC> npcList = new List<NPC> ();

    public void init () {
        createNPCs(numOfNpcs); 
        assignRandomJobs();
    }

    public void createNPCs(int num)
    {
         for (int v = 0; v <= (num - 1); v++) {
             
            npcList.Add(Instantiate(npcPrefab, new Vector3(-75, 0, 0), Quaternion.identity));
        }
    }

    public static void assignRandomJobs() {
            
         foreach (NPC npc in npcList) {
            JobManager.AssignRandomJob(npc);
        }
    }

    public static void sendAllNPCsHome(){
       
       foreach (NPC npc in npcList) {
            npc.go(npc.house);
       }
    }

    
    public static void assignJob (Job job, NPC npc) {
        /*if (job.isAvailable()) {
            job.increaseCurrent();
            npc.job = job;
            npc.JobTitle = job.type;
        } else {
            Debug.Log("Failed to assign job: " + job.type + " to " + npc.fullName);
        }*/

        Debug.Log("Failed to assign job: " + job.type + " to " + npc.fullName);
    }

    public static void removeJob (NPC npc) {
        npc.job = null;
        npc.JobTitle = "Unemployed";
    }
    

}

