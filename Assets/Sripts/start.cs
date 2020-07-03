using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
  public GameObject Second;
  public GameObject First;
    public void go()
    {
      Second.SetActive(true);
      First.SetActive(false);
        
    }
    public void Play(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    
    public void Back(){
      Second.SetActive(false);
      First.SetActive(true);
    }

    public void Reset(){
      PlayerPrefs.DeleteAll();
    }
}
