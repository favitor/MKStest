using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Transform spawnFrontal, spawnSide, spawnSide2, spawnSide3;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        LookAtMouse();
        Move();
        FrontalShot();
        SideShot();
        
    }

    private void LookAtMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y
        );

        transform.up = direction;

    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }

    }

    private void FrontalShot()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnFrontal.position, spawnFrontal.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(spawnFrontal.up * bulletSpeed, ForceMode2D.Impulse);
        };

    }

    private void SideShot()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnSide.position, spawnSide.rotation);
            GameObject bullet2 = Instantiate(bulletPrefab, spawnSide2.position, spawnSide2.rotation);
            GameObject bullet3 = Instantiate(bulletPrefab, spawnSide3.position, spawnSide3.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
            Rigidbody2D rb3 = bullet3.GetComponent<Rigidbody2D>();
            rb.AddForce(-spawnSide.right * bulletSpeed, ForceMode2D.Impulse);
            rb2.AddForce(-spawnSide2.right * bulletSpeed, ForceMode2D.Impulse);
            rb3.AddForce(-spawnSide3.right * bulletSpeed, ForceMode2D.Impulse);
        };

    }

}
