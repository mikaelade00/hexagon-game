using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public static float value = 0;
    public Text scoretext;
    public Text hightext;
    

    void Start()
    {
      hightext.text = PlayerPrefs.GetFloat("high", 0).ToString("0");
    }

    public void Update() {
        scoretext.text = value.ToString("0");
        
        if (value > PlayerPrefs.GetFloat("high", 0)){
        PlayerPrefs.SetFloat("high", value);
        hightext.text = value.ToString();
        }
    }
    
    public void Reset(){
      PlayerPrefs.DeleteAll();
      hightext.text = "0";
    }
   
           
        
    
}
