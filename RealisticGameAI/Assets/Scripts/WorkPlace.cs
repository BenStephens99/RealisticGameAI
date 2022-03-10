using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkPlace : Building
{
    public List <NPC> workers;
    public int maxNumber;

    public void add(NPC npc) {
        if (hasVacancy()){
            workers.Add(npc);
            npc.workPlace = this;
        } else {
            Debug.Log("All positions taken");
        }
    }

    public bool hasVacancy(){
        if (workers.Count < maxNumber) {
            return true;
        } else {
            return false;
        }
    }


}
