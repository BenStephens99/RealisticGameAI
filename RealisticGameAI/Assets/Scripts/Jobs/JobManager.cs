using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    public static Job[] jobs = new Job[2];
    public static CoffeeShop[] coffeeShops;
    public static OfficeBuilding[] officeBuildings;
    static int lastAssignedJob = 0;
    static int jobsChecked = 0;
    static bool availableJobs = true;

    public void init () {

       coffeeShops = FindObjectsOfType<CoffeeShop>();
       officeBuildings = FindObjectsOfType<OfficeBuilding>();

        jobs [0] = new Job("Barista", coffeeShops.Length * 2);
        jobs [1] = new Job("Office", officeBuildings.Length * 9);
    }

    public static void AssignRandomJob (NPC npc) {
          
        Job job = jobs[lastAssignedJob];
        
        if (availableJobs) {
            if (job.isAvailable()) {
                    job.add(npc);
                    findAvailableWorkPlace(job, npc);
                    lastAssignedJob++;
                    jobsChecked = 0;
                    if (lastAssignedJob > jobs.Length - 1) {
                        lastAssignedJob = 0;
                    }
                }   else if (jobsChecked < jobs.Length - 1) {
                        Debug.Log("No Available " + job.type);
                        lastAssignedJob++;
                        jobsChecked++;
                        AssignRandomJob(npc);
                    }   else {
                            Debug.Log("No available jobs left");
                            npc.job = null;
                            availableJobs = false;
                        }
            } else { 
                Debug.Log("No available jobs left");
                npc.job = null;
            }
    }


    public static void findAvailableWorkPlace (Job job, NPC npc) {

        int i = 0;
        bool wpFound = false;
        WorkPlace[] workPlaces;

        switch (job.type) {
             
            case "Barista": 
            workPlaces = coffeeShops;
            break;

            case "Office": 
            workPlaces = officeBuildings;
            break;

            default: 
            workPlaces = null;
            break;
        }

           
        while (!wpFound) {
            if (workPlaces[i].hasVacancy()) {
                wpFound = true;
            } else {
                i++;
                if (i > workPlaces.Length - 1) {
                    i = 0;
                }
            }
        }
        
        workPlaces[i].add(npc); 

    }
    
    
}



