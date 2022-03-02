using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public string road;
    public int number;
    public int capacity;
    public int occupancy;

    void Start() {
        road = assignRoad();
        number = assignHouseNumber();
    }
    
    string assignRoad() {

        int i = Random.Range(0, HouseManager.RoadNames.Length);

        return HouseManager.RoadNames[i];
    } 

    int assignHouseNumber() {

        int i = Random.Range(1, 50);
        return i;
    }

}


