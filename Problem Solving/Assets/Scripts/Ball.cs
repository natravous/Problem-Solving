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
    }

    // Update is called once per frame
    void Update()
    {
        float rand = Random.RandomRange(0, 4);
        movement.x = rand;
        movement.y = rand;
        Debug.Log(movement);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * speed * Time.deltaTime));
    }

}
