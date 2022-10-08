using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth;
    protected SpriteRenderer sprite;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        enemyHealth -=damage;
        if(enemyHealth <=0)
        {
            Debug.Log("Enemy Died");
            Destroy(gameObject);
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
