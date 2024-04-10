using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
        Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
        //    Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        //}
    }

    public void EnemySpawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
        Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
    }


}