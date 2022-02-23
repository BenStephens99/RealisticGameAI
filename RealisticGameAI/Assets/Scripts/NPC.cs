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
    public Job job;

void Start()
    {
        sex = AssignSex();
        age = Random.Range(1, 80);
        fullName = AssignName(sex);
        happiness = Random.Range(0, 100);
    }

    public string AssignSex()
    {
        int sexInt = Random.Range(0, 2);
        if (sexInt == 0)
        {
            return "Male";
        }
        else
        {
            return "Female";
        }
    }

    public string AssignName(string sex)
    {

        string[] maleNames = {"James", "Robert", "John", "Micheal", "William", "David",
    "Richard", "Joseph", "Thomas", "Charles"};

        string[] femaleNames = {"Mary", "Patricia", "Jennifer", "Linda", "Elizabeth",
    "Barbara", "Susan", "Jessica", "Sarah", "Karen"};

        string[] surnames = {"Brown", "Johnson", "Jones", "Green", "Smith", "Williams",
    "Evans", "Walker", "Green", "Wood"};

        string RandName;

        if (sex == "Male")
        {
            RandName = maleNames[Random.Range(0, maleNames.Length)] + " " +
            surnames[Random.Range(0, surnames.Length)];

        }
        else
        {
            RandName = femaleNames[Random.Range(0, femaleNames.Length)] + " " +
            surnames[Random.Range(0, surnames.Length)];
        }

        return RandName;
    }
    public void AssignJob () {
         
        int i = Random.Range(0, GameManager.jobs.Length);

        if (GameManager.jobs[i].isAvailable()) {
            GameManager.jobs[i].increaseCurrent();
            job = GameManager.jobs[i];
            JobTitle = GameManager.jobs[i].type;
        } else {
            AssignJob();
        }
    }
}