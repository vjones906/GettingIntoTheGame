using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private const float xRange = 10;
    private const float spawnPoint2 = 20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnAnimals()
    {
        int randomAnimals = Random.Range(0, animals.Length);
        Instantiate(animals[randomAnimals], new Vector3(Random.Range(-10.0f, 10.0f), 0, spawnPoint2), animals[randomAnimals].transform.rotation);
    }
}
