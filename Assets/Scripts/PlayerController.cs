using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // The speed of the ball.
    public float Speed = 10;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // A reference to the ball's RigitBody component.
    private Rigidbody body;
    private int count;

    // Start is called before the first frame update.
    void Start()
    {
        body = GetComponent<Rigidbody>();

        // Set count to 0
        count = 0;

        SetCountText ();

        // Set the text property of the Win Text UI to an empty string, making the 'You Win' (game over message) blank
        winTextObject.SetActive(false);
    }

    // FixedUpdate is called before each step in the physics engine.
    private void FixedUpdate()
    {
        float horizontalForce = Input.GetAxis("Horizontal") * Speed;
        float verticalForce = Input.GetAxis("Vertical") * Speed;
        body.AddForce(new Vector3(horizontalForce, 0, verticalForce));
    }

    void OnTriggerEnter(Collider other) 
	{
		// ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("PickUp"))
		{
			other.gameObject.SetActive (false);

			// Add one to the score variable 'count'
			count = count + 1;

			// Run the 'SetCountText()' function (see below)
			SetCountText ();
		}
	}

    void SetCountText()
	{
		countText.text = "Count: " + count.ToString();

		if (count >= 8) 
		{
            // Set the text value of your 'winText'
            winTextObject.SetActive(true);
		}
	}
}