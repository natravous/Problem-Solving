using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFour : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5f;

    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        LauchBall();
    }

    public void LauchBall()
    {
        rb.MovePosition(rb.position + (movement * speed * Time.deltaTime));

    }
}
