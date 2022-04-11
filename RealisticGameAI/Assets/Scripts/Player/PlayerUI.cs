using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI date;
    public TextMeshProUGUI time;

    
void Update () {
    date.text = TimeDate.day;
    time.text = TimeDate.currentTime;
}

}