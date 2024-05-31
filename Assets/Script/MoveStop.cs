using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStop : MonoBehaviour
{
    private Dog dog;

    private void Awake()
    {
        dog = GetComponent<Dog>();
    }

    public void Wait()
    {
        StartCoroutine("Stop");
    }


    private IEnumerator Stop()
    {
        yield return new WaitForSeconds(1f);
        dog.Move();
        yield return new WaitForSeconds(2f);
        dog.StopMove();
        yield return new WaitForSeconds(1f);
        dog.Move();
        yield return new WaitForSeconds(2f);
        dog.StopMove();
        yield return new WaitForSeconds(5f);
        dog.Move();
    }
}
