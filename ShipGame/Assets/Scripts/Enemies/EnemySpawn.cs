using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnTime;
    public Transform spawnPosition;
    public GameObject[] enemies;
    public int choosedEnemy;
    //public GameObject chaserPrefab;
    //public GameObject shooterPrefab;

    void Start()
    {
        spawnTime = ButtonController.spawnTimeChoosed;
        StartCoroutine("spawnEnemy");
        
    }

    private IEnumerator spawnEnemy()
    {
        choosedEnemy = Random.Range(0, enemies.Length);
        //GameObject newEnemy = Instantiate(enemies[choosedEnemy], spawnPosition.position, spawnPosition.rotation);
        GameObject newEnemy = Instantiate(enemies[choosedEnemy], new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6), 0), Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
    }

}
