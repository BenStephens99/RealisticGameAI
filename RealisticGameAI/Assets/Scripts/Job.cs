using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Job {
    public string type;
    public int maxNumber;
    public int currentNumber;
    public static Job[] jobs = new Job[4];
    public static Job Unemployed;

    public Job (string _type, int _maxNum) {
        type = _type;
        maxNumber = _maxNum;
    }


    public static void init() {
       
       Unemployed = new Job ("Unemployed", 999); 

       Job BuissnessPerson = new Job("Buinssness Person", 10);
       Job Barista = new Job("Barista", 20);
       Job Batman = new Job("Batman", 1);
       Job ShopWorker = new Job("Shop Worker", 19);

       jobs [0] = BuissnessPerson;
       jobs [1] = Barista;
       jobs [2] = Batman;
       jobs [3] = ShopWorker;

    }


    public bool isAvailable ()
    {
        if (currentNumber >= maxNumber) {
            return false;
        } else {
            return true;
        }
    }
    public void increaseCurrent () {
       currentNumber++;
    }
    public static void assignJob (Job job, NPC npc) {
        if (job.isAvailable()) {
            job.increaseCurrent();
            npc.job = job;
            npc.JobTitle = job.type;
        } else {
            Debug.Log("Failed to assign job: " + job.type + " to " + npc.fullName);
        }
    }

    public static void removeJob (NPC npc) {
        npc.job = Unemployed;
        npc.JobTitle = npc.job.type;
    }

    public static void AssignRandomJob (NPC npc) {
         
        int i = Random.Range(0, jobs.Length);

        if (jobs[i].isAvailable()) {
            jobs[i].increaseCurrent();
            npc.job = jobs[i];
            npc.JobTitle = jobs[i].type;
        } else {
            AssignRandomJob(npc);
        }
    }
    
}

