using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkPlace : Building
{
    public List <NPC> workers = new List<NPC>();
    public WorkingPos[] workingPositions;
    public OrderPos[] orderingPos;
    int lastAssPos = 0;
 
    virtual public void add(NPC npc) {
        if (hasVacancy()){
            workers.Add(npc);
            npc.workPlace = this;
            workingPositions[lastAssPos].add(npc);
            lastAssPos++;
        } else {
            Debug.Log("All positions taken");
        }
    }

    virtual public bool hasVacancy(){
        if (workers.Count < workingPositions.Length) {
            return true;
        } else {
            return false;
        }
    }


}
