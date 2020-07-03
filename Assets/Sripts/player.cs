using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float movespeed = 50f;
    float movement = 0f;
    
    void Update()
    {
       movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate() 
    {
        transform.RotateAround( Vector3.zero, Vector3.forward, movement*Time.fixedDeltaTime*-movespeed);    
    }

    void OnTriggerEnter2D(Collider2D collisionInfo)
   {
       Debug.Log(collisionInfo.gameObject.tag);
       Debug.Log(collisionInfo.gameObject.name);
       if(collisionInfo.gameObject.tag=="hexagon")
       {
         FindObjectOfType<GameManager>().EndGame();
        score.value = 0;
       }
       else  if(collisionInfo.gameObject.name=="Hexagon Poin(Clone)")
      {
          score.value ++;
          FindObjectOfType<AudioManager>().PlaySound("Poin");
       }
       
     
   }
}
