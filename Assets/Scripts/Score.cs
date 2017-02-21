using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gets when the player hits a coin and then updates the score to add 5 points
public class Score : MonoBehaviour
{
    public static int score;

	void Start()
	{
		// Set the score to 0 everytime the scene loads
		score = 0;
	}

    void Update ()
    {
    	// Update the text on screen with the new score
        GetComponent<GUIText>().text = "Score: " + score;
	}

	// If the message has been sent from Collision being hit, then add 5 points to score
	static public void AddPoint()
	{
		score += 5;
	}
}
