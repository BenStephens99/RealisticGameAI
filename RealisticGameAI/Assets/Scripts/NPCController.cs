using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{

    public NPC npc;
    NavMeshAgent agent;
   
    public Vector3 destination;

    void Awake() {
        agent = GetComponent<NavMeshAgent>();
    
    }
    void Start () {
        npc.stateMachine.Start();
        agent.speed = npc.speed;
    }

    void Update() {
        npc.stateMachine.Update();
    }
    
    void LateUpdate() {
        npc.stateMachine.LateUpdate();
    }

    public void goToDestination(Vector3 des) {
         destination = des;
         agent.SetDestination(destination); 
    }

    public void go() {
        agent.isStopped = false;
        agent.SetDestination(destination);
    }

    public void stop() {
        agent.isStopped = true;
    }
    
}
