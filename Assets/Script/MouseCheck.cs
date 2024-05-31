using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCheck : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }

    private void Update()
    {
        if(gameManager.isStart == true)
        {
            Vector2 mousePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            if (mousePos != Vector2.zero)
                gameManager.FallGame();
        }
    }
}
