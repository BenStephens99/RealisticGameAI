using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDate 
{
  
    static public gameTime time;
    static public string day;
    static public string currentTime;
    public static int dayCounter;

     float t = 0.0f;
     float interpolationPeriod = 1.0f;

    public TimeDate() {
        time = new gameTime();

       time.hour = 6;
       time.minute = 50;
       dayCounter = 1;
       day = "Monday";
    }


   public void Update (float engineClock) {
        t += engineClock;
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
