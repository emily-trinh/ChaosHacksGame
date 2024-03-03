using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 2.0f; // Adjust this to control the speed of the movement
    public float amplitude = 1.0f; // Adjust this to control the distance of the movement

    private Rigidbody2D rb;
    private Vector2 startingPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = rb.position;
    }

    void FixedUpdate()
    {
        // Calculate the vertical movement using a sine wave
        float verticalMovement = Mathf.Sin(Time.time * speed) * amplitude;

        // Set the velocity of the Rigidbody2D to move the object up and down
        rb.position = startingPosition + new Vector2(0, verticalMovement);
    }
}
