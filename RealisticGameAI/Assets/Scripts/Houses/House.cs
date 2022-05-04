using System.Collections;
using System.Collections.Generic;

public class House : Building
{
    public string road;
    public int number;
    public int capacity;
    public List<NPC> Occupants = new List<NPC>();

    void Awake() {
        road = this.GetComponentInParent<ResidentialRoad>().RoadName;
        number = this.GetComponentInParent<HouseSpawnPoint>().spawnPointNumber;
    }

    public void add(NPC npc) {
        Occupants.Add(npc);
        npc.house = this;
    }

    public void remove(NPC npc) {
        Occupants.Remove(npc);
        npc.house = null;
    }
}


