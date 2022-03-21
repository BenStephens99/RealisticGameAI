using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCActions : MonoBehaviour
{

    NPC npc;

    public Building findClosest() {
        return JobManager.coffeeShops[1];
    }

    void Awake(){
        npc = GetComponent<NPC>();
    }

    public void getCoffee() {
        
        foreach(CoffeeShop CoffeeShop in JobManager.coffeeShops){

        }
    }

    public void sit (Chair chair) {
        chair.add(npc);
        npc.controller.goToDestination(chair.transform.position);

    }
}
