using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple script that records the time since the game starts and displays in-game
public class TimerScript : MonoBehaviour
{
    private float time;
    float minutes;
    float seconds;

	void Start ()
	{
        time = 0;
	}

	void Update ()
	{
        time += Time.deltaTime;

        if(time > 0)
        {
            minutes = Mathf.Floor(time / 60);
            seconds = Mathf.Floor(time % 60);
            GetComponent<GUIText>().text = " " + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
	}
}
