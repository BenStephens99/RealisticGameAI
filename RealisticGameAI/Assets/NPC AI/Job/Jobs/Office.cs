using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Office : Job {
      
    public Office () : base ("Office", 9) { }
    
    public override void init() {
      base.init();
        maxNumber = (JobManager.officeBuildings.Length) * maxPerStore;
      startTime.hour = 9;
      startTime.minute =0;

      endTime.hour = 17;
      endTime.minute = 0;

      days = new int[7] {1,1,1,1,1,0,0};
    
    }

    public override void Update(NPC npc)
    {
        base.Update(npc);
    }
}

