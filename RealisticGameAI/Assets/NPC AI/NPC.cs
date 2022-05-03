using System;
public class NPC
{

    //Personal Details
    public string fullName;  
    public string sex;
    public int age;
    public int happiness;
    public string JobTitle;
    public int idNumber;
    public int speed;
    public string hand; 

    //System components
    public StateMachine stateMachine;
    public Memory memory;
    
    //Job
     public Job job;
    public WorkPlace workPlace;
    public WorkingPos workPos;

    //House
    public House house;
    public bool move;

    Random rand = new Random();

public NPC()
    {
        sex = AssignSex();
        age = rand.Next(18, 30);
        fullName = AssignName(sex);
        happiness = rand.Next(0, 100);
        hand = randomHand();
        speed = generateSpeed();
        stateMachine = new StateMachine(this);
        memory = new Memory();
    }


    string randomHand() { 
        int i = rand.Next(1, 11);
       
       if (i >= 3) {
           return "Right";
       } else {
           return "Left";
       }
    }

    string AssignSex() {
        int sexInt = rand.Next(0, 2);
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
            RandName = maleNames[rand.Next(0, maleNames.Length)] + " " +
            surnames[rand.Next(0, surnames.Length)];
        }
        
        else{
            RandName = femaleNames[rand.Next(0, femaleNames.Length)] + " " +
            surnames[rand.Next(0, surnames.Length)];
        }

        return RandName;
    }
    int generateSpeed() {

    var rand = new Random();
        switch (age) {
            
            case int n when (n <= 30):
                return rand.Next(7, 10) /2;

            case int n when (n > 30 && n <= 40): 
                return rand.Next (6, 9) /2;

            case int n when (n > 40 && n <= 50):
                return rand.Next (5, 7) /2;
            
            case int n when (n > 50 && n <= 60):
                return rand.Next (4, 6) /2;

            case int n when (n > 60 && n <=80 ):
                return rand.Next(3, 5) /2 ;

            default: 
                return rand.Next (2, 4) /2 ;

        } 

        
    }

  
}