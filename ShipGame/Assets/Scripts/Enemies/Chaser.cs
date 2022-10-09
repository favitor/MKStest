using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float speed = 2f;
    public GameObject deathEffect;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void Update()
    {
        //Look at Player
        Vector2 targetPos = player.transform.position;
        movement = targetPos - (Vector2)transform.position;
        transform.up = movement;

    }

    private void FixedUpdate()
    {
        moveChaser(movement);
    
    }

    void moveChaser(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (movement * speed * Time.deltaTime));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.25f);
            Destroy(gameObject);
            collision.gameObject.TryGetComponent<HealthPlayer>(out HealthPlayer playerComponent);
            playerComponent.TakeDamage(1);
        }
    }
}
