using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public int numOfNpcs;
    public NPC npcPrefab;
    public List<NPC> npcList = new List<NPC> ();

    public void init () {
        createNPCs(numOfNpcs); 
        assignRandomJobs();
    }

    public void createNPCs(int num)
    {
         for (int v = 0; v <= (num - 1); v++) {
            npcList.Add(Instantiate(npcPrefab, new Vector3(-75 , 0, 0 + (v+5)), Quaternion.identity));
            npcPrefab.idNumber = v+1;
        }
    }

    public  void assignRandomJobs() {
         foreach (NPC npc in npcList) {
            JobManager.AssignRandomJob(npc);
        }
    }

    public void sendAllNPCsHome(){
       foreach (NPC npc in npcList) {
           Debug.Log (npc.house.transform.position +  " " + npc.transform.position); 
            npc.transform.position = npc.house.transform.position;
       }
    }

    public static void removeJob (NPC npc) {
        npc.job = null;
        npc.JobTitle = "Unemployed";
    }
    


}

