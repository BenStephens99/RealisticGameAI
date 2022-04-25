using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{

    public static Job[] jobs;
    public static CoffeeShop[] coffeeShops;
    public static OfficeBuilding[] officeBuildings;
    public static ItemShop[] itemShops;
    


    static Barista barista;
    static Merchant merchant;
    static Office office;

    static int lastAssignedJob = 0;
    static int jobsChecked = 0;
    static bool availableJobs = true;

    public void init () {

        coffeeShops = FindObjectsOfType<CoffeeShop>();
        officeBuildings = FindObjectsOfType<OfficeBuilding>();
        itemShops = FindObjectsOfType<ItemShop>();

        barista = new Barista();
        merchant = new Merchant();
        office = new Office();
    
        jobs = new Job[] {barista, merchant, office};

    }

    public static void AssignRandomJob (NPC npc) {
          
        while (availableJobs) {
             lastAssignedJob++;
            if (lastAssignedJob >= jobs.Length) {
                lastAssignedJob = 0;
            }
            if (jobs[lastAssignedJob].isAvailable()) {
                jobs[lastAssignedJob].add(npc);
                lastAssignedJob++;
                jobsChecked = 0;
                return;
            } 
            else {
                jobsChecked++;
                if (jobsChecked >= jobs.Length) {
                    npc.job = null;
                    availableJobs = false;
                    return;
                }
            }
        }  
        npc.job = null;
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



