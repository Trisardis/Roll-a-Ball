using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundZ : MonoBehaviour
{
	// The speed at which the coin rotates.
	public float Speed = 10;

	// FixedUpdate is called before each step in the physics engine.
	void FixedUpdate()
	{
		transform.Rotate(0, 0, Speed);
	}
}