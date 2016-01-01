using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public Text Score;
	public Text HighScore;


	// Use this for initialization
	void Start () {
		Score.text=" Your Current  Score:  "+PlayerPrefs.GetInt("Time");
		HighScore.text = " High Score:  " +PlayerPrefs.GetInt("BestTime");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
