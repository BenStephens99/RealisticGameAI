using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Job {
    public string type;
    public int maxPerStore;
    public int currentNumber;
    public int maxNumber;

    public gameTime startTime;
    public gameTime endTime;

    public int[] days;

    public Job (string _type, int _perStore) {
        type = _type;
        maxPerStore = _perStore;
        init();
    }
    public bool isAvailable(){
        if (currentNumber < maxNumber) {
            return true;
        } else {
             return false;
        }
    }
    public void add (NPC npc) {
        npc.job = this;
        npc.JobTitle = this.type;
        currentNumber ++;
        JobManager.findAvailableWorkPlace(this, npc);
    }

    public void remove(NPC npc) {
        npc.job = null;
        npc.JobTitle = "Unemployed";
        currentNumber --;
    }

    public virtual void init() {
        days = new int[7] {1,1,1,1,1,0,0};
        startTime.hour = 9;
        startTime.minute = 0;
        endTime.hour = 17;
        endTime.minute = 0;
    }
    public virtual void Update(NPC npc) {
         if (TimeDate.time.hour == npc.job.endTime.hour && TimeDate.time.minute == npc.job.endTime.minute) {
            Debug.Log("Shift Over");
            npc.nextDestination = npc.house;
            npc.stateMachine.changeState(StateMachine.moving);
        }
    }
    
}

