using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// If collision with player is detected then add 5 points to score
public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Score.AddPoint();
        }
    }
}
