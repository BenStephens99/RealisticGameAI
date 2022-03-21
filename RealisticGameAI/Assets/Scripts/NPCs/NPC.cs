using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string fullName;  
    public string sex;
    public int age;
    public int happiness;
    public string JobTitle;
    public int IdNumber;
    public string hand;

    public Job job;
    public WorkPlace workPlace;
    public House house;
    public NPCController controller;
    public NPCActions actions;


void Awake()
    {
        controller = GetComponent<NPCController>();
        actions = GetComponent<NPCActions>();
        IdNumber = AssignID();
        sex = AssignSex();
        age = Random.Range(18, 90);
        fullName = AssignName(sex);
        happiness = Random.Range(0, 100);
        hand = randomHand();
    }

    string randomHand() {
        int i = Random.Range(1, 10);
       
       if (i >= 3) {
           return "right";
       } else {
           return "left";
       }
    }

    int AssignID() {
        return 0;
    }

    string AssignSex() {
        int sexInt = Random.Range(0, 2);
        if (sexInt == 0) {
            return "Male";
        }
        else {
            return "Female";
        }
    }

    string AssignName(string sex) {

        string[] maleNames = {"James", "Robert", "John", "Micheal", "William", "David",
                                "Richard", "Joseph", "Thomas", "Charles"};

        string[] femaleNames = {"Mary", "Patricia", "Jennifer", "Linda", "Elizabeth",
                                "Barbara", "Susan", "Jessica", "Sarah", "Karen"};

        string[] surnames = {"Brown", "Johnson", "Jones", "Green", "Smith", "Williams",
                                "Evans", "Walker", "Green", "Wood"};

        string RandName;

        if (sex == "Male") {
            RandName = maleNames[Random.Range(0, maleNames.Length)] + " " +
            surnames[Random.Range(0, surnames.Length)];
        }
        
        else{
            RandName = femaleNames[Random.Range(0, femaleNames.Length)] + " " +
            surnames[Random.Range(0, surnames.Length)];
        }

        return RandName;
    }



}