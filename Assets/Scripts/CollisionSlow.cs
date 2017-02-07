using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Detects collision with the Player and sends a message to the Playerscript for a slowdown
public class CollisionSlow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
		    // When player hits object, send message to playerscript to request the slowdown effect
            collision.gameObject.SendMessage("hasHit");
            Destroy(gameObject);
        }
    }
}
