using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionEffect;
    public float bulletSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.25f);
        Destroy(gameObject);
        switch(collision.gameObject.tag)
        {
            case "Wall":
            Destroy(gameObject);
            Debug.Log("hits wall");
            break;

            case "Enemy":
            Destroy(gameObject);
            Debug.Log("hits enemy");
            collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent);
            enemyComponent.TakeDamage(1);
            break;
        }
        /*if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);

        }*/
    }

}
