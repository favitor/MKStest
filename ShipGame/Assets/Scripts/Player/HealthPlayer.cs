using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public Sprite damage1Sprite, damage2Sprite, deadSprite;
    public HealthBar healthBar;
    protected SpriteRenderer sprite;
    public GameObject deathEffect;
    public int playerHealth;
    public int playerMaxHealth;
    public GameController other;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetHealth(playerHealth, playerMaxHealth);
        healthBar.Slider.value = playerMaxHealth;
        sprite = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        playerHealth -=damage;
        healthBar.SetHealth(playerHealth, playerMaxHealth);

        if(playerHealth <=0)
        {
            sprite.sprite = deadSprite;
            //UIManager.scoreValue++;
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.25f);

            //Call GameOver Funtion
            other.GameOver();
        }
        
        if(playerHealth == 10)
        {
            sprite.sprite = damage1Sprite;
        }

        if(playerHealth == 5)
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
