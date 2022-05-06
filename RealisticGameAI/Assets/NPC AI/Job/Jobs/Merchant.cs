using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Merchant : Job {
      
    public Merchant () : base ("Merchant", 1) { }
    
    public override void init() {
      base.init();
      maxNumber = (JobManager.itemShops.Length) * maxPerStore;
      startTime.hour = 12;
      startTime.minute =0;

      endTime.hour = 22;
      endTime.minute = 0;

      days = new int[7] {1,1,0,1,0,1,0};
    
    }
}

