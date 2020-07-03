using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoin : MonoBehaviour
{
    public float spawanrate = 1f;
    public GameObject poin;
    private float next = 0f;
 
  
    void Update()
    {
        if ( Time.time >= next)
        {
            Instantiate(poin, Vector3.zero, Quaternion.identity);
            next = Time.time + 1f / spawanrate;
        }
    }
}