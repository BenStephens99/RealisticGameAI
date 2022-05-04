using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HouseManager : MonoBehaviour
{
 public House housePrefab;
 public ResidentialRoad[] roads;
 public static List<House> houses = new List<House>();
 int availableSpawnPoints;
 int roadStart = 0;
 int roadEnd = 0;

    public void init () {

     roads = FindObjectsOfType<ResidentialRoad>();
     availableSpawnPoints = roads.Length * 6;

     foreach (ResidentialRoad road in roads) {
         road.RoadName = AssignRoadName();
     }

    }

    string AssignRoadName() {
        string RoadName;

        string[] RoadStarts = {"First", "Second", "Third", "Fourth", "Fith", "Sixth", "Seventh", "Eighth"};
        string [] RoadEnds = {"Street", "Lane", "Park", "Drive", "Avenue", "Road"};

       RoadName = RoadStarts[roadStart] + " " + RoadEnds[roadEnd];
       roadStart++;
       if (roadStart > RoadStarts.Length -1) {
           roadEnd++;
           roadStart = 0;
       }

        return RoadName;
    }

     public void createHouses(List<NPC> npcs) {

        int r = 0 ;
        int sp = 0;

       for (int n = 0; n < npcs.Count; n++) {
            if (r > roads.Length - 1) {
                r = 0;
                sp++;
            }
            if (sp == 6) {
                sp = 0;
            } 
            spawnHouseWithNPC(roads[r].spawnPoints[sp], npcs[n]);
            r++;
       }
       
    }

    public void spawnHouseWithNPC(HouseSpawnPoint sp, NPC npc) {
        if (!sp.occupied) { 
            House newHouse = Instantiate(housePrefab, sp.transform);
            newHouse.add(npc);
            sp.occupied = true;
        } else {
            sp.GetComponentInChildren<House>().add(npc);

        }
            
    }

    public void spawnHouse(HouseSpawnPoint sp) {
        if (!sp.occupied) {
            House newHouse = Instantiate(housePrefab, sp.transform);
            houses.Add(newHouse);
        } 
            else {
                Debug.Log ("House Already at location" + sp.transform); 
            }
    }
}

