using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numOfNpcs;
    public NPC NPCPrefab;
    public static Job[] jobs = new Job[4];
    List<NPC> NPCs = new List<NPC> ();
    
    void Start()
    {
        
       Job BuissnessPerson = new Job("Buinssness Person", 10);
       Job Barista = new Job("Barista", 20);
       Job Batman = new Job("Batman", 1);
       Job ShopWorker = new Job("Shop Worker", 19);

       jobs [0] = BuissnessPerson;
       jobs [1] = Barista;
       jobs [2] = Batman;
       jobs [3] = ShopWorker;

        for (int v = 0; v <= (numOfNpcs - 1); v++) {
            NPCs.Add(Instantiate(NPCPrefab));
        }


        foreach (NPC npc in NPCs)
        {
           npc.AssignJob();
        } 

        for (int i = 0; i < numOfNpcs; i++) {
            Debug.Log((i+1) + ": " +NPCs[i].fullName + ": " + NPCs[i].job.type);
        }
    }


    void Update()
    {
        
    }

}


