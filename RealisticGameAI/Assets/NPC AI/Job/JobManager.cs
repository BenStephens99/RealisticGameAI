using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager
{
    public static Job[] jobs;
    public static CoffeeShop[] coffeeShops;
    public static OfficeBuilding[] officeBuildings;
    public static ItemShop[] itemShops;
    public static Bar[] bars;
    
    static Barista barista;
    static Merchant merchant;
    static Office office;
    static BarPerson barPerson;

    static int lastAssignedJob = 0;
    static int jobsChecked = 0;
    static bool availableJobs = true;

    public JobManager(CoffeeShop[] _coffeeShops, OfficeBuilding[] _officeBuildings, ItemShop[] _itemShops, Bar[] _bars) {
        coffeeShops = _coffeeShops;
        officeBuildings = _officeBuildings;
        itemShops = _itemShops;
        bars = _bars;

        barista = new Barista();
        merchant = new Merchant();
        office = new Office();
        barPerson = new BarPerson();
    
        jobs = new Job[] {barista, merchant, office, barPerson};
    }

    public void AssignRandomJob (NPC npc) {
        while (availableJobs) {
             lastAssignedJob++;
   
            if (lastAssignedJob >= jobs.Length) {
                lastAssignedJob = 0;
            }

            if (jobs[lastAssignedJob].isAvailable()) {
                jobs[lastAssignedJob].add(npc);
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

            case "BarPerson":
            workPlaces = bars;
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



