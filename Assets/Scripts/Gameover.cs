using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gameover : MonoBehaviour {

	// Use this for initializatio



    // Use this for initialization
   // public Canvas quitMenu;
 
    public Button exitText;
    public Button mainmenu;

    void Start()
    {
       // quitMenu = quitMenu.GetComponent<Canvas>();
     
        exitText = exitText.GetComponent<Button>();
        mainmenu = mainmenu.GetComponent<Button>();
    }
    public void Mainmenu()
    {
        Application.LoadLevel(0);
    }
    

    public void ExitGame()     //  exit menu yes press closes game
    {
         Application.Quit();
        //Application.LoadLevel(1);
    }

}

