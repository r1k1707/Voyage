using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab; // Place enemy prefab in here
    [SerializeField] int enemyAmount;

    [SerializeField] private float enemySpawnRate; // Time between spawns - can edit the amount

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            float randomX = Random.Range(-1, 1);
            float randomY = Random.Range(4, 18);
            enemy.transform.position = new Vector3(randomX, randomY, 0);
            yield return new WaitForSeconds(enemySpawnRate);
        }
    }
}