using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnPosX = 20.0f;

    private float spawnPosZ = 33.0f;

    private float startDelay = 2.0f;

    private float repeatRate = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        // call custom method after startDelay each repeatRate
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnPosX,spawnPosX),0,spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
