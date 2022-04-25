using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{   
    public NPC me;
    public State currentState;
    public static Idle idle;
    public static Moving moving;
    public static Working working;

    void Awake () {
        moving = new Moving();
        idle = new Idle();
        working = new Working();
        me = GetComponentInParent<NPC>();
        currentState = idle;
    }

    void Start () {
        currentState = idle;
        currentState.Enter(me);
    }

    void Update () {
        if (currentState != null) {
            currentState.UpdateLogic(me);
        }
    }

    void LateUpdate() {
         if (currentState != null) {
            currentState.UpdatePhysics(me);
        }
    }

    public void OnTriggerEnter (Collider collider)
    {
        if (collider.tag == "NPC") {
        NPC npc = collider.GetComponent<NPC>();
        currentState.OnCollision(me, npc);
        }
    }

    public void changeState (State newState) {
        currentState.Exit(me);
        currentState = newState;
        currentState.Enter(me);
        me.state = currentState.stateName;
    }


}


