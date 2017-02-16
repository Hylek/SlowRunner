using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simply rotates the coins on the z axis to make them spin in real time
public class Rotator : MonoBehaviour
{
	void Update ()
	{
  		transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
