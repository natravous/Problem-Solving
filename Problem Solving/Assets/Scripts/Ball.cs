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
    }

    private void FixedUpdate()
    {
        rb.transform.position = Vector2.MoveTowards(transform.position, mousePosition, Time.deltaTime * speed);

        LauchBall();
    }

    public void LauchBall()
    {
        rb.MovePosition(rb.position + (movement * speed * Time.deltaTime));
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Box")
        {
            Score.scoreValue++;
            Destroy(collision.gameObject);
        }
    }
}
