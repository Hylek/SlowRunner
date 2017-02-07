using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes background scroll endlessly at a controlled speed
public class BGScroller : MonoBehaviour
{
    public float speed;

	void Update ()
    {
		// Telling the background to move horizontally in relation to time
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
