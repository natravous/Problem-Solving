using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5f;

    private Vector2 movement;
    private Vector3 mousePosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //
        //rb.velocity = new Vector2(5f, 5f);
        movement = new Vector2(0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        }


        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //movement = Vector2.Lerp(transform.position, mousePosition, speed);
    }

    private void FixedUpdate()
    {
        rb.transform.position = Vector2.MoveTowards(transform.position, mousePosition, Time.deltaTime * speed);

        LauchBall();
    }

    public void LauchBall()
    {
        //float rand = Random.RandomRange(0, 4);
        //movement.x = rand;
        //movement.y = rand;
        //Debug.Log(movement);

        rb.MovePosition(rb.position + (movement * speed * Time.deltaTime));
        //rb.MovePosition(movement);

    }

}
