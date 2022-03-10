using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossing : MonoBehaviour
{

    public bool canCross;
    public Collider waitPoint1;
    public Collider waitPoint2;
    public List<NPC> waitingNPCs;

    void onCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "NPC"){
            Debug.Log("NPC and Crossing collide");
   }
    }


   
}
