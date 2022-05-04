using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Barista : Job {
      
    public Barista () : base ("Barista", 2) { }
    
    public override void init() {
      base.init();
      maxNumber = (JobManager.coffeeShops.Length) * maxPerStore;
      startTime.hour = 1;
      startTime.minute = 0;

      endTime.hour = 5;
      endTime.minute = 30;

      days = new int[7] {1,1,1,1,1,1,0};
    }

    public override void work(NPC npc)
    {
        base.work(npc);

    }
}

