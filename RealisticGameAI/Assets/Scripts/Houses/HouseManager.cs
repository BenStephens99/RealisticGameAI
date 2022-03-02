using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour
{
 

 public House house;
 public static List<House> houses = new List<House>();
 public static string[] RoadNames = new string[4];
 

    public void init () {

         RoadNames[0] = "Park Lane";
         RoadNames[1] = "Bond Street";
         RoadNames[2] = "Oxford Street";
         RoadNames[3] = "Regent Street";
    }

     public void createHouses(List<NPC> npcs) {
         
            for (int i = 0; i < npcs.Count; i++) {
                House newHouse = Instantiate(house, new Vector3(i * 10.0F, 0, 0), Quaternion.identity);
                houses.Add(newHouse);
                npcs[i].house = newHouse;
            }
    }
}
