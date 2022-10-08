using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public HealthBar healthBar;
    public int enemyMaxHealth;
    public int enemyHealth;

    protected SpriteRenderer sprite;
    public GameObject deathEffect;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();        
    }

    void Start()
    {
        healthBar.SetHealth(enemyHealth, enemyMaxHealth);
        healthBar.Slider.value = enemyMaxHealth;
        
    }

    public void TakeDamage(int damage)
    {
        enemyHealth -=damage;
        healthBar.SetHealth(enemyHealth, enemyMaxHealth);

        if(enemyHealth <=0)
        {
            Destroy(gameObject);
            UIManager.scoreValue++;
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.25f);
        }
        else
        {
            StartCoroutine(TookDamageCoRoutine());
        }
    }

    IEnumerator TookDamageCoRoutine()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
}
