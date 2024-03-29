using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
	// OnTriggerEnter is called when another collider touches this collider.
	private void OnTriggerEnter(Collider other)
	{
		Destroy(this.transform.parent.gameObject);
	}
}