using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera script that tracks the player with added offsets
public class SmoothTracking : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        // Camera follows the player with specified offset positioning
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
    }
}
