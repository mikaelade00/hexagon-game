using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnrate = 1f;
    public GameObject hexagon;
    public GameObject poin;
    private float next = 0f;
 
    
    void delay()
    {
        spawnrate = spawnrate + (score.value/1000000);
    }
    void Update()
    {
        Invoke ("delay",3f);
    
        if (spawnrate>=2f)
        {
            spawnrate = 2f;
        }
        Debug.Log(spawnrate);
        if ( Time.time >= next)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            next = Time.time + 2f / spawnrate;
            Instantiate(poin, Vector3.zero, Quaternion.identity);
            next = Time.time + 2f / spawnrate;
        }
       
    }
}
