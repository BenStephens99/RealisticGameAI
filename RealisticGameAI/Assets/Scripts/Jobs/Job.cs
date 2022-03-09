using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Job {
    public string type;
    public int maxNumber;
    public int currentNumber;

    public Job (string _type, int _maxNum) {
        type = _type;
        maxNumber = _maxNum;
    }

    public bool isAvailable() {
      
        if (currentNumber >= maxNumber) {
            Debug.Log("false");
            return false;
        } else {
             Debug.Log("true");
            return true;
        }

    }

        public void add (NPC npc) {
            npc.job = this;
            npc.JobTitle = this.type;
            currentNumber ++;
        }

        public void remove(NPC npc) {
            npc.job = null;
            npc.JobTitle = "Unemployed";
            currentNumber --;
        }
    
}

