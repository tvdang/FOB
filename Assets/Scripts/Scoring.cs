using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour

{/*
   / private float elapsedTime = 0; // The amount of time that has elapsed.
    private int points = 100; // The player's current points.
    private float score = 0;               // Use this for initialization
    private TextMesh text;
    public static float timeSinceLevelLoad;

    // Update is called once per frame
    void Start()
    {
        text = gameObject.GetComponent<TextMesh>();
    }
    void Update()
    {
        // Update your timer every frame.
        elapsedTime += Time.deltaTime;
        AssignPoints();

    }
    float AssignPoints()
    {
      
        score = elapsedTime * points;
        return score;
        text.text = "score is" + score;
    }*/
    private float score; // Time.time is a float, not an int

    // Initalization
    void OnStart()
    {

        // Retrieve the score
        score = PlayerPrefs.GetFloat("score", 0.0f); // default score is 0.0f

    }

    // Display the score
    void OnGUI()
    {

        GUI.Label(new Rect( 200,100,0,0), score.ToString()); // Give new Rect() the position and size

    }

    // OnDestroy (ie. when the player quits)
    void OnDestroy()
    {

        // Save the score
        PlayerPrefs.SetFloat("score", Time.time);

    }
}