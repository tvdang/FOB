using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gameover : MonoBehaviour {

	// Use this for initializatio



    // Use this for initialization
   // public Canvas quitMenu;
 
	public Text Score;
	public Text HighScore;



    public Button exitText;
    public Button mainmenu;

    void Start()
    {
       // quitMenu = quitMenu.GetComponent<Canvas>();

		Score.text=" Your Score:  "+PlayerPrefs.GetInt("Time");
		HighScore.text = " High Score:  " +PlayerPrefs.GetInt("BestTime");
        exitText = exitText.GetComponent<Button>();
        mainmenu = mainmenu.GetComponent<Button>();
    }
    public void Mainmenu()
    {
		Application.LoadLevel("fob");
    }
    

    public void ExitGame()     //  exit menu yes press closes game
    {
		Application.LoadLevel("MainMenu");
        //Application.LoadLevel(1);
    }

}

