using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRange = 20.0f;

    public GameObject[] animalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        Vector3 position = new Vector3(Random.RandomRange(-spawnRange, spawnRange), 0, spawnRange);
        int index = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[index], position, animalPrefabs[index].transform.rotation);
    }
}
