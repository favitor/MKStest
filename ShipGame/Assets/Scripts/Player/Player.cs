using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Transform spawnFrontal;
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
            //GameObject bullet = Instantiate(bulletPrefab, spawnFrontal.position, spawnFrontal.rotation);
            //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            //rb.AddForce(spawnFrontal.up * bulletSpeed, ForceMode2D.Impulse);
            //transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
            Debug.Log("FrontalShoot");
            Instantiate(bulletPrefab, spawnFrontal.position, transform.rotation);
        };

    }

    private void SideShot()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Debug.Log("SideShoot");
        };

    }

}
