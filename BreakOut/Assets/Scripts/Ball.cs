using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rb;
    public Transform spawnpoint;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up; //new Vector2(Random.Range(-1f,1f),1f);
    }

    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var brick = other.gameObject.GetComponent<Brick>();

        if (brick)
        {
            brick.Damage();
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.lives--;
        transform.position = spawnpoint.position;
    }



}
