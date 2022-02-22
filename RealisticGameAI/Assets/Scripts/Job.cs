using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Job {
    public string type;
    public int maxNumber;
    public int currentNumber;

    public Job (string _type, int _maxNum) {
        type = _type;
        maxNumber = _maxNum;
    }

    public bool isAvailable ()
    {
        if (currentNumber >= maxNumber) {
            return false;
        } else 
        {
            return true;
        }
    }
    public void increaseCurrent () 
    {
       currentNumber++;
    }

    
}

