using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelText : MonoBehaviour
{
    private TextMeshProUGUI levelText;
    // Start is called before the first frame update
    private void Awake()
    {
        levelText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Start()
    {
        levelText.text = "Last Level Completed: " + GameManager.level;
    }
}
