using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple script that plays the video on the main menu scene
public class MovieScript : MonoBehaviour
{
	void Start ()
    {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
    }
}
