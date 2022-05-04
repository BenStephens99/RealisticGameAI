using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Merchant : Job {
      
    public Merchant () : base ("Merchant", 1) { }
    
    public override void init() {
      base.init();
      maxNumber = (JobManager.itemShops.Length) * maxPerStore;
    }
}

