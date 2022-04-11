using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkPlace : Building
{
    public List <NPC> workers;
    public List<WorkingPos> workingPos = new List<WorkingPos>();
    public int maxNumber;
    int lastAssPos = 0;
  
    virtual public void add(NPC npc) {
        if (hasVacancy()){
            workers.Add(npc);
            npc.workPlace = this;
            //npc.workPos = this.workingPos[lastAssPos].transform;
            //lastAssPos++;
        } else {
            Debug.Log("All positions taken");
        }
    }

    virtual public bool hasVacancy(){
        if (workers.Count < maxNumber) {
            return true;
        } else {
            return false;
        }
    }


}
