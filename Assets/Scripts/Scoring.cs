using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour
{
    private float elapsedTime = 0; // The amount of time that has elapsed.
    private int points = 100; // The player's current points.
    private float score = 0;               // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        // Update your timer every frame.
        elapsedTime += Time.deltaTime;

    }
    float AssignPoints()
    {
      
        score = elapsedTime * points;
        return score;
    }
}