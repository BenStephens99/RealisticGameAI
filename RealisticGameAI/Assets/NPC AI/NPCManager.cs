using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class NPCManager 
{
    public JobManager jobManager;

    public List<NPC> npcList = new List<NPC> ();

    public NPCManager(int num) {
        
        createNPCs(num); 
    }

    public void createNPCs(int num)
    {
         for (int v = 0; v <= (num - 1); v++) {
            NPC newNPC = new NPC();
            npcList.Add(newNPC);
            newNPC.idNumber = v+1;
        }
    }

    public void assignRandomJobs(CoffeeShop[] _coffeeShops, OfficeBuilding[] _officeBuildings, ItemShop[] _itemShops) {
         jobManager = new JobManager(_coffeeShops, _officeBuildings, _itemShops);
         foreach (NPC npc in npcList) {
            jobManager.AssignRandomJob(npc);
            
        }
    }





}

