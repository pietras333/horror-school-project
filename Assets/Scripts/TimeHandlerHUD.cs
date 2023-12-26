using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity;

public class TimeHandlerHUD : MonoBehaviour
{
    [Header("Time Handler for HUD")]
    [Space]
    [Header("Necessary")]
    [Space]
    [SerializeField] TextMeshProUGUI timeText;
    
    void Update(){
        int seconds = (int)Time.time%60;
        int minutes = (int)(Time.time%3600) / 60;
        int hours = (int)Time.time/3600;

        string formattedTime = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        timeText.text = formattedTime;
    }
}
