using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class about : MonoBehaviour
{

    // Use this for initialization
   
    public Button backText;
    void Start()
    {
        
        backText = backText.GetComponent<Button>();
      

    }

    // custom functions
    public void backPress()
    {
        Application.LoadLevel(0);
    }



}
