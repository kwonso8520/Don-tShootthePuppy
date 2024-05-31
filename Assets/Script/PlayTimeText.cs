using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayTimeText : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private int min;
    private int sec;

    private void Awake()
    {
        timeText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        min = ((int)GameManager.playTime) / 60;
        sec = ((int)GameManager.playTime) % 60;
        timeText.text = "Time Spent Not Shooting the Puppy: " + min + " min " + sec + " sec";
    }
}
