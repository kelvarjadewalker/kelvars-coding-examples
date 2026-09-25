using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnDelay = 2.0f;

    // Cache variable to hold the reference
    private WaitForSeconds delay;

    private void Start()
    {
        // Allocate the memory ONCE here
        delay = new WaitForSeconds(spawnDelay);

        StartCoroutine(SpawnWaves());
    }

    private IEnumerator SpawnWaves()
    {
        while (true)
        {
            //  Efficient: Reuses the same exact memory pointer
            yield return delay;
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        // Spawning logic here.
        // For this tutorial, we will not cover object pooling, that will address this issue but
        // is a bit more advanced.
        var enemy = Instantiate(enemyPrefab);
        Destroy(enemy, 5.0f);
    }
}