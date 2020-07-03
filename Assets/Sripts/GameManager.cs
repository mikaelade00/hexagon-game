using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameend = false;
    public float delay = 1f;
    // public GameObject completeUI;
    //public void complete ()
    //{
       // completeUI.SetActive(true);
    //}
    public void EndGame()
    {
       if (gameend == false)
       {
           gameend = true;
           Debug.Log("GAME OVER");
           Invoke ("restart", 0f);
       }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   
}
