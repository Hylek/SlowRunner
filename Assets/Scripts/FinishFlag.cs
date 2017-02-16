using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sends a message to playermove script to tell it to switch to the gameover scene upon collision
public class FinishFlag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.SendMessage("isFinished");
			print("Message sent!");
        }
    }
}
