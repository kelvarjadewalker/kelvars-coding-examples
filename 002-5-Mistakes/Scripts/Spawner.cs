using System.Collections;
using UnityEngine;

// #4 - Spawning Coroutines with `yield return new WaitForSeconds()`
public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }


    private IEnumerator SpawnWaves()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f); // Allocates memory!
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        // Spawn an enemy; this covers another common pattern of repeatedly calling Instantiate.
        // For this tutorial, we will not cover object pooling, that will address this issue but
        // is a bit more advanced.
        var enemy = Instantiate(enemyPrefab);
        Destroy(enemy, 5.0f);
    }

}
