using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighLevelCheck : MonoBehaviour
{
    private TextMeshProUGUI high_levelText;
    // Start is called before the first frame update
    private void Awake()
    {
        high_levelText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Start()
    {
       
    }
    private void Update()
    {
        if (GameManager.level >= PlayerPrefs.GetInt("Your Highest Level Completed: "))
            PlayerPrefs.SetInt("Your Highest Level Completed: ", GameManager.level);

        high_levelText.text = "Your Highest Level Completed: " + PlayerPrefs.GetInt("Your Highest Level Completed: ");
    }
}
