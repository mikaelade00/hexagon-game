using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poin : MonoBehaviour
{

    public Rigidbody2D rbp;
    public float shrinkspeed = 3f;
    void Start()
    {
     rbp.rotation = Random.Range(0f,360f);
     transform.localScale = Vector3.one*10f;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrinkspeed * Time.deltaTime;
        if (transform.localScale.x <= 0.5f){
           Destroy(gameObject);
        }
    }
}
