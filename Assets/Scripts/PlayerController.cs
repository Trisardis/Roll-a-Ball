using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // The speed of the ball.
    public float Speed = 10;

    // A reference to the ball's RigitBody component.
    private Rigidbody body;

    // Start is called before the first frame update.
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called before each step in the physics engine.
    private void FixedUpdate()
    {
        float horizontalForce = Input.GetAxis("Horizontal") * Speed;
        float verticalForce = Input.GetAxis("Vertical") * Speed;
        body.AddForce(new Vector3(horizontalForce, 0, verticalForce));
    }
}