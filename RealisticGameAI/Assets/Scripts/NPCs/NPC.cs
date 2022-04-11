using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;

public class NPC : MonoBehaviour
{


    public string fullName;  
    public string sex;
    public int age;
    public int happiness;
    public string JobTitle;
    public int idNumber;
    public string hand; 
    public string state;
    public StateMachine stateMachine;

    public Job job;
    public WorkPlace workPlace;
    public House house;
    public Transform workPos;

    [HideInInspector]
    public NPCController controller;

    [HideInInspector]
    public NPCActions actions;
    private IntelligentAgent Agent;

    [DllImport("Engine.dll")]
    [return: MarshalAs(UnmanagedType.BStr)]
    private static extern void init(int id, string name);

  

void Awake()
    {
        controller = GetComponent<NPCController>();
        actions = GetComponent<NPCActions>();
        Agent = GetComponent<IntelligentAgent>();
        sex = AssignSex();
        age = Random.Range(18, 30);
        fullName = AssignName(sex);
        happiness = Random.Range(0, 100);
        hand = randomHand();
        stateMachine = GetComponent<StateMachine>();
        state = "";
    }

    void Start() {
        //init(idNumber, fullName);
    }

    string randomHand() { 
        int i = Random.Range(1, 11);
       
       if (i >= 3) {
           return "Right";
       } else {
           return "Left";
       }
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
                                "Evans", "Walker", "Davies", "Wood"};

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