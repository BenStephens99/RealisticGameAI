using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class BarPerson : Job {
      
    public BarPerson () : base ("BarPerson", 2) { }
    
    public override void init() {
      base.init();
      maxNumber = (JobManager.coffeeShops.Length) * maxPerStore;
      startTime.hour = 17;
      startTime.minute = 0;

      endTime.hour = 2;
      endTime.minute = 0;

      days = new int[7] {0,1,1,1,1,1,0};
    }

    public override void work(NPC npc)
    {
        base.work(npc);

    }
}

