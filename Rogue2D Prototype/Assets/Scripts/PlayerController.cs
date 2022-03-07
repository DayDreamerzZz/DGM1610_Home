using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player moves at
    private Rigidbody2D rb; // Store the referenced 2D rigidbody

    Vector2 movement; //Store the players x,y, position for movement

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Left Right Movement
        movement.y = Input.GetAxis("Vertical"); // Up Down Movement
    }
    // Set number of calls per frame
    void FixedUpdate()
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
