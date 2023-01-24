using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15f;
    private float spawnRangeZTop = 15f;
    private float spawnRangeZBot = 5f;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalH", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalV", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalH()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZTop);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalV()
    {
        float randRangeX = Random.Range(0, 2) == 0 ? spawnRangeX : -spawnRangeX;
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(randRangeX, 0, Random.Range(spawnRangeZTop, spawnRangeZBot));

        if (randRangeX == spawnRangeX)
        {
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0,-90,0));
        }
        
        else if (randRangeX == -spawnRangeX)
        {
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, +90, 0));
        }
    }
}
