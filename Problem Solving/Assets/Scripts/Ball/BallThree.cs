using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThree : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5f;

    //private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(5f, 5f);

        Debug.Log(rb.velocity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        //LauchBall();
    }

    public void LauchBall()
    {
        //rb.MovePosition(rb.position + (movement * speed * Time.deltaTime));

    }
}
