using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script that handles everything relating to the player
public class PlayerMove : MonoBehaviour
{
    public float currentSpeed = 0.0f;
    public float maxSpeed = 5.0f;
    public float acceleration = 0.1f;
    public float jumpSize = 300f;
	public float slowBy = 5;
	public float speedBy = 1;

    public bool didJump = false;
	private Rigidbody2D rb2d;

	void Start ()
	{
	    rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
	    // Adding automatic movement, horizontally
        rb2d.AddForce(Vector2.right * currentSpeed);

		// Adding acceleration to the player
        currentSpeed += acceleration;

        if(currentSpeed > maxSpeed)
        {
            currentSpeed = maxSpeed;
        }

		// Setting didJump to true if player has pressed the Spacebar
        if(Input.GetKeyDown(KeyCode.Space))
        {
            didJump = true;
        }
    }

	void FixedUpdate ()
	{
		// If didJump is true then move the player vertically, then set didJump back to false
        if(didJump)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSize);
            didJump = false;
        }
	}

	// If the player has hit something then slow them down.
    void hasHit()
    {
		currentSpeed -= slowBy;
        print("Player Slowed!");
    }

	// If the player hits a coin then maxSpeed increases by 1 for every coin hit
	void hitCoin()
	{
	    maxSpeed += speedBy;
		print("Player Speed Increased!");
	}

    // If the player has reached the end of the game, display game complete scene with score
    void Finished()
    {
        // Application.LoadLevel(GameOver);
    }
}
