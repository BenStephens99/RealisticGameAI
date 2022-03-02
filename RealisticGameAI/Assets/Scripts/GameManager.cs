using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public NPCManager NPCM;
    public HouseManager HM;

    public Player player;

    void Awake () {
        Job.init();
        NPCM.init();
        HM.init();
    }
    
    void Start()
    {
        HM.createHouses(NPCM.npcs);

        //Instantiate(player);

    }



}


                                