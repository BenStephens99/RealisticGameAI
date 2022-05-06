using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Runtime.InteropServices;


public class GameManager : MonoBehaviour
{
        
    public NPCManager npcManager;   
    public int numOfNpcs;
    public HouseManager hm;
    public Player player;
    public NavMeshSurface surface; 
    public NPCController npcController;

    [DllImport("Engine.dll")]
    [return: MarshalAs(UnmanagedType.BStr)]
    static extern string aprroached(Info npc, string state);

    static public TimeDate timeDate;
    void Awake () {
        timeDate = new TimeDate();

        npcManager = new NPCManager(numOfNpcs);
        npcManager.assignRandomJobs(
            FindObjectsOfType<CoffeeShop>(), FindObjectsOfType<OfficeBuilding>(), 
            FindObjectsOfType<ItemShop>(), FindObjectsOfType<Bar>());

        hm.init();

        hm.createHouses(npcManager.npcList);
        surface.BuildNavMesh();

        foreach(NPC npc in npcManager.npcList) {
            NPCController newNPC = Instantiate(npcController, npc.house.transform, false);
            newNPC.npc = npc;
            npc.controller = newNPC;
        }
    }
    
    void Start()
    {
        
    }  
    
    void Update () {
        timeDate.Update(Time.deltaTime);
    }
    
}
                                