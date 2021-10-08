using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5f;

    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //
        //rb.velocity = new Vector2(5f, 5f);
       
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
        //float rand = Random.RandomRange(0, 4);
        //movement.x = rand;
        //movement.y = rand;
        //Debug.Log(movement);

        rb.MovePosition(rb.position + (movement * speed * Time.deltaTime));

    }

}
