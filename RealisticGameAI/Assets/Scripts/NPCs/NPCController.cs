using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{

    NavMeshAgent agent;
    NPC npc;
    public int speed;
    public Vector3 destination;

    void Awake() {
         
        npc = GetComponent<NPC>();
        agent = GetComponent<NavMeshAgent>();


        speed = generateSpeed();
        agent.speed = speed;
    }

    int generateSpeed() {

        switch (npc.age) {
            
            case int n when (n <= 30):
                return Random.Range(7, 10);

            case int n when (n > 30 && n <= 40): 
                return Random.Range (6, 9);

            case int n when (n > 40 && n <= 50):
                return Random.Range (5, 7);
            
            case int n when (n > 50 && n <= 60):
                return Random.Range (4, 6);

            case int n when (n > 60 && n <=80 ):
                return Random.Range (3, 5);

            default: 
                return Random.Range (2, 4);

        } 

    }
    public void goToDestination(Vector3 des) {

        Debug.Log("Go to Destination " + des);
         destination = des;
         agent.SetDestination(destination);
    }
    
}
