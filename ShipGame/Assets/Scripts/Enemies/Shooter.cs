using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float speed = 2f;
    public Transform spawnShoot;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    private float timeBtwShots;
    public float startTimeBtwShots;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        timeBtwShots = startTimeBtwShots;
        
    }

    
    void Update()
    {
 
        if(timeBtwShots <= 0)
        {
            Shot();
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        //Look at Player
        Vector2 targetPos = player.transform.position;
        movement = targetPos - (Vector2)transform.position;
        transform.up = movement;
        
    }

    private void Shot()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnShoot.position, spawnShoot.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(spawnShoot.up * bulletSpeed, ForceMode2D.Impulse);
        timeBtwShots = startTimeBtwShots;

    }
}
