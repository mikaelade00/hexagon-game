using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexapoin : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collisionInfo)
   {
    
     if(collisionInfo.GetComponent<Collider>().tag=="poin")
      {
          score.value +=1;
          
       }
   }
   
}
