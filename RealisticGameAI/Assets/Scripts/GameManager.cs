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


    void Awake () {
        
        jm.init();
        npcm.init();
        hm.init();
    }
    
    void Start()
    {
        hm.createHouses(npcm.npcList);
        surface.BuildNavMesh();
    }   

    void Update () {

        if (Input.GetKeyDown("e")) {
           foreach (NPC npc in npcm.npcList) {
               npc.controller.destination = npc.house.transform.position;
           }
        }

        if (Input.GetKeyDown("space")) {
                   foreach (NPC npc in npcm.npcList) {
                       npc.stateMachine.changeState(StateMachine.moving);
                   }
        }
        
    }
}


                                