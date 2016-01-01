using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoremenu : MonoBehaviour {

	// Use this for initialization
	

      //public Button exitText;
    public Button score;
    public Canvas quitMenu;
    void Start()
    {
         quitMenu = quitMenu.GetComponent<Canvas>();

        //exitText = exitText.GetComponent<Button>();
        score = score.GetComponent<Button>();
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