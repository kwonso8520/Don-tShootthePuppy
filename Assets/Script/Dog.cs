using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Move()
    {
        StartCoroutine("MoveDog");
    }

    public void StopMove()
    {
        StopCoroutine("MoveDog");
    }

    private IEnumerator MoveDog()
    {
        while (true)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            yield return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            gameManager.EndGame();
            GameManager.level = GameManager.level + 1;
        }
    }
}
