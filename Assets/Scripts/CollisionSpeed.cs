using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Detects collision with the Player and sends a message to the Playerscript for an increase in max speed
public class CollisionSpeed : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.name == "Player")
		{
			// if player hits coin, then send a request to increase player max speed by one
			collision.gameObject.SendMessage("hitCoin");
			Destroy(gameObject);
		}
	}
}
