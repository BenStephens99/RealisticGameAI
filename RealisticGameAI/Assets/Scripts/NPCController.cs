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

    public void OnTriggerEnter (Collider collider)
    {   
        if (collider.tag == "NPC") {
            NPCController controller = collider.GetComponent<NPCController>();
            npc.stateMachine.onCollision(controller.npc);
        } else if (collider.tag == "Player") {
            Player player = collider.GetComponent<Player>();
            npc.stateMachine.onCollision(player.npc);
        }
    }

    public void go() {
        if (npc.nextDestination == null) {npc.nextDestination = npc.house;}
        agent.SetDestination(npc.nextDestination.transform.position);
        agent.isStopped = false;
    }

    public void stop() {
        agent.isStopped = true;
    }
    
}
