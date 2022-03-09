using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
  
    public static Job[] jobs = new Job[2];

    public static CoffeeShop[] coffeeShops;

   

    public void init () {

       coffeeShops = FindObjectsOfType<CoffeeShop>();

        jobs [0] = new Job("Barista", (coffeeShops.Length) * 2);
    }

      public static void AssignRandomJob (NPC npc) {
          
        int randNum = Random.Range(0, jobs.Length -1);

        Job job = jobs[randNum];

        for (int i = 0; i < jobs.Length - 1; i++) {
            Debug.Log(jobs[i].type);
        }
      
        Debug.Log (job.currentNumber + "" + job.maxNumber);
        if (job.isAvailable()) {
                job.add(npc);
                findAvailableWorkPlace(job, npc);
        }   else {
                Debug.Log("No Available jobs");
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



