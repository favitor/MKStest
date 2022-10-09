using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Sprite damage1Sprite, damage2Sprite, deadSprite;
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
            sprite.sprite = deadSprite;
            Destroy(gameObject, 0.25f);
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.25f);
            UIManager.scoreValue++;
        }

        if(enemyHealth == 3)
        {
            sprite.sprite = damage1Sprite;
        }

        if(enemyHealth == 1)
        {
            sprite.sprite = damage2Sprite;
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
