using UnityEngine;

public class CameraController : MonoBehaviour
{
	// A reference to the player object.
	public GameObject Player;
	
	// The distance between the camera and the player object.
	private Vector3 Offset;

	// Start is called before the first frame update.
	void Start()
	{
		// GameObject.Find() is very expensive so never have this function in Update()
		// Only put it in Start()
		// Player = GameObject.Find("Player");
		Offset = this.transform.position - Player.transform.position;
	}

	// LateUpdate is called after Update but before rendering the frame.
	void LateUpdate()
	{
		this.transform.position = Player.transform.position + Offset;
	}
}
