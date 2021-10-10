using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTwo : MonoBehaviour
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
        float rand = Random.Range(0f, 4f);
        movement.x = rand;
        movement.y = rand;
        Debug.Log(movement);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * speed * Time.deltaTime));
    }
}
