using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionEffect;
    public float bulletSpeed = 5f;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.25f);
        Destroy(gameObject);
        switch(collision.gameObject.tag)
        {
            case "Wall":
            Destroy(gameObject);
            break;

            case "Enemy":
            Destroy(gameObject);
            collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent);
            enemyComponent.TakeDamage(1);
            break;

            case "Player":
            Destroy(gameObject);
            collision.gameObject.TryGetComponent<HealthPlayer>(out HealthPlayer playerComponent);
            playerComponent.TakeDamage(1);
            break;
        }
    }

}
