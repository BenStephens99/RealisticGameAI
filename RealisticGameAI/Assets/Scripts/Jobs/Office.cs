using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Office : Job {
      
    public Office () : base ("Office", 9) { }
    
    public override void init() {
        maxNumber = (JobManager.officeBuildings.Length) * maxPerStore;
    }
}

