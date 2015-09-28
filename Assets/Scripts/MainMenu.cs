using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour
{

	// Use this for initialization
	public Canvas quitMenu;
    public Canvas scoreMenu;
    public Button startText;
    public Button scoreText;
    public Button aboutText;
    public Button exitText;
    
    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        scoreMenu = scoreMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        scoreText = scoreText.GetComponent<Button>();
        aboutText = aboutText.GetComponent<Button>();
        
        quitMenu.enabled = false;
        scoreMenu.enabled = false;
    }



    public void aboutPress()   //about button press
    {
        Debug.Log("About Pressed");
        Application.LoadLevel(2);

    }


    public void ScorePress()     // score button pressed open menu
    {

        quitMenu.enabled = false;
        scoreMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        scoreText.enabled = false;
        aboutText.enabled = false;

    }

    public void NoScorePress()       //close score menu
    {
        quitMenu.enabled = false;
        scoreMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        scoreText.enabled = true;
        aboutText.enabled = true;
    }
        public void ExitPress()         // exit press open up exit menu
    {
        Debug.Log("Exit Prssed");
        quitMenu.enabled = true;
        scoreMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        scoreText.enabled = false;
        aboutText.enabled = false;

    }

    

	public void NoPress()           // exit button no press close exit menu
    {
        quitMenu.enabled = false;
        scoreMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        scoreText.enabled = true;
        aboutText.enabled = true;
    }
	
	public void StartLevel()        // start game button pressed opens main game
    {
        Application.LoadLevel(1);
    }
	
    public void ExitGame()     //  exit menu yes press closes game
    {
        Application.Quit();

    }
	
}
