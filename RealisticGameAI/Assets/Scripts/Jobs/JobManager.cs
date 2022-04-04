using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    public static Job[] jobs = new Job[3];
    public static CoffeeShop[] coffeeShops;
    public static OfficeBuilding[] officeBuildings;
    public static ItemShop[] itemShops;
    static int lastAssignedJob = 0;
    static int jobsChecked = 0;
    static bool availableJobs = true;

    public void init () {

       coffeeShops = FindObjectsOfType<CoffeeShop>();
       officeBuildings = FindObjectsOfType<OfficeBuilding>();
       itemShops = FindObjectsOfType<ItemShop>();

        jobs [0] = new Job("Barista", coffeeShops.Length * 2);
        jobs [1] = new Job("Office", officeBuildings.Length * 9);
        jobs [2] = new Job("Merchant", itemShops.Length * 1);
    }

    public static void AssignRandomJob (NPC npc) {
           
           if (availableJobs) { 
                Job job = jobs[lastAssignedJob]; 
                if (job.isAvailable()) { 
                    job.add(npc);
                    findAvailableWorkPlace(job, npc);
                    lastAssignedJob++; 
                    Debug.Log("LAJ " + lastAssignedJob );
                    jobsChecked = 0; 
                    if (lastAssignedJob >= jobs.Length - 1) { 
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

            case "Merchant":
            workPlaces = itemShops;
            break;

            default: 
            workPlaces = null;
            break;
        }

           
        while (!wpFound) { // currently O(n)
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



