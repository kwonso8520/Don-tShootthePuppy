using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostApear : MonoBehaviour
{
    public GameObject ghost;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whaaaa()
    {
        Invoke("apear",2f);
    }
    void apear()
    {
        ghost.SetActive(true);
    }
}
