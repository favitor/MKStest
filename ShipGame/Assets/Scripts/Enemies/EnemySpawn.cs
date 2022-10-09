using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnTime;
    public Transform spawnPosition;
    public GameObject[] enemies;
    public int choosedEnemy;

    void Start()
    {
        spawnTime = ButtonController.spawnTimeChoosed;
        
        InvokeRepeating("spawnEnemy", 1, spawnTime);
        
    }

    public void spawnEnemy()
    {
        choosedEnemy = Random.Range(0, enemies.Length);
        GameObject newEnemy = Instantiate(enemies[choosedEnemy], spawnPosition.position, spawnPosition.rotation);
    }

}
