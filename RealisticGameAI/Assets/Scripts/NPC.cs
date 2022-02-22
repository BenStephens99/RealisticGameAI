using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public string fullName;
    public int age;
    public int happiness;
    public Job job;
    private string sex;


void Start()
    {
        sex = RandomSex();
        age = Random.Range(1, 80);
        fullName = RandomName(sex);
        happiness = Random.Range(0, 100);
    }

    public string RandomSex()
    {
        int sexInt = Random.Range(0, 2);
        if (sexInt == 0)
        {
            return "m";
        }
        else
        {
            return "f";
        }
    }

    public string RandomName(string sex)
    {

        string[] maleNames = {"James", "Robert", "John", "Micheal", "William", "David",
    "Richard", "Joseph", "Thomas", "Charles"};

        string[] femaleNames = {"Mary", "Patricia", "Jennifer", "Linda", "Elizabeth",
    "Barbara", "Susan", "Jessica", "Sarah", "Karen"};

        string[] surnames = {"Brown", "Johnson", "Jones", "Green", "Smith", "Williams",
    "Evans", "Walker", "Green", "Wood"};

        string RandName;

        if (sex == "m")
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


}