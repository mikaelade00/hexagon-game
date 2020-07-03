using UnityEngine;

public class pcollision : MonoBehaviour
{

    
   void OnCollisionEnter(Collision collisionInfo)
   {
       
       if(collisionInfo.collider.tag=="hexagon")
      {
      
        FindObjectOfType<GameManager>().EndGame();
       }
     
   }
}
