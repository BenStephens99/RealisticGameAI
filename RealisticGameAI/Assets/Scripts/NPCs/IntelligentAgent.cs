using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelligentAgent : MonoBehaviour
{
 private float time = 0.0f;
 public float interpolationPeriod = 1.0f;

public struct woldInfo {
int time;
int day;


}

    void Update()
    {
         time += Time.deltaTime;
         if (time >= interpolationPeriod) {
         time = time - interpolationPeriod;

        

     }
    }
}
