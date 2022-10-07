using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public GameObject explosionEffect;
    //public float destroyTime = 2f;
    public float bulletSpeed = 20f;

    /*void Start()
    {
        Destroy(gameObject, destroyTime);
    }*/

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(explosionEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject);
    }

}
