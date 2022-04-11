using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDate : MonoBehaviour
{
   public struct time {
      static public int hour;
      static public int minute;
    }
    static public string day;
    static public string currentTime;

    int dayCounter;

     float t = 0.0f;
     float interpolationPeriod = 1.0f;

   void Start () {
       time.hour = 00;
       time.minute = 00;
       dayCounter = 1;
       day = "Monday";
   }

   void Update () {
        t += Time.deltaTime;
         if (t >= interpolationPeriod) {
         t = t - interpolationPeriod;

        time.minute++;

        if (time.minute >= 60) {
            time.minute = 0;
            time.hour++;
            if (time.hour >= 24) {
                time.hour = 0;
                dayCounter++;
                if (dayCounter > 7) {
                    dayCounter = 1;
                }
                 switch (dayCounter) {
                    case 1: 
                    day = "Monday";
                    break;
                    case 2:
                    day = "Tuesday";
                    break;
                     case 3: 
                    day = "Wednesday";
                    break;
                    case 4:
                    day = "Thursday";
                    break;
                     case 5: 
                    day = "Friday";
                    break;
                    case 6:
                    day = "Saturday";
                    break;
                     case 7: 
                    day = "Sunday";
                    break;
                }
            }
        }
        currentTime = time.hour.ToString("00") + ":" + time.minute.ToString("00");
     }
   }

}
