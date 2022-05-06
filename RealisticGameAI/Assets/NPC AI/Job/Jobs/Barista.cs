using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Barista : Job {
      
    public Barista () : base ("Barista", 2) { }
    
    public override void init() {
      base.init();
      maxNumber = (JobManager.coffeeShops.Length) * maxPerStore;
      startTime.hour = 8;
      startTime.minute =0;

      endTime.hour = 18;
      endTime.minute = 0;

      days = new int[7] {1,1,1,1,1,0,1};
    }

      public override void Update(NPC npc)
    {
        base.Update(npc);
    }
}

