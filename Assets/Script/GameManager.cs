using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    private Dog dog;
    public static int level;
    public bool isStart = false;
    public int stage;
    public static float playTime = 0;

    void Start()
    {

    }

    private void Update()
    {
        if(isStart)
        {
            playTime += Time.deltaTime;
        }
    } 

    public void GameStart()
    {
        isStart = true;
        if(stage == 3)
        {
            dog.GetComponent<MoveStop>().Wait();
        }
        else
        {
            dog.Move();
        }
    }

    public void FallGame()
    {
        SceneManager.LoadScene("Fail");
    }

    public void EndGame()
    {
        SceneManager.LoadScene(stage);
    }
}
