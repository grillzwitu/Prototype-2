using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs; //List of animals to be spawned 
    public float spawnRangeX = 20; //Distance along x-axis within which animals can be spawn
    public float spawnPosZ = 20; //Distance along z-axis within which animals can be spawn
    private float startDelay = 2; //Timer before spawn
    private float startInterval = 1.5f; //Interval till next spawn

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
        */
    }

    void SpawnRandomAnimal()
    {
        //Random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        //Randomly spawn the animals
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Spawn the animals
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
