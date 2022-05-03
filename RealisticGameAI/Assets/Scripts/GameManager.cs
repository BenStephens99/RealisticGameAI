using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class GameManager : MonoBehaviour
{
        
    public NPCManager npcm;
    public HouseManager hm;
    public JobManager jm;
    public Player player;
    public NavMeshSurface surface; //VS bug
    public Transform testLocation;

    public NPCController NpcPrefab;




    void Awake () {
        
        jm.init();
        npcm.init();
        hm.init();

        hm.createHouses(npcm.npcList);
        surface.BuildNavMesh();

        foreach(NPC npc in npcm.npcList) {
        NPCController newNPC = Instantiate(NpcPrefab, npc.house.transform, false);
        newNPC.npc = npc;
        }
   
    }
    
    void Start()
    {
     
    
    }  

}
                                