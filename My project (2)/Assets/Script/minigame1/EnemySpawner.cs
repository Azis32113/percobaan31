using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] SpawnPoint;
    public GameObject[] OilPrefabs;
    public float RealOilChance = 0.80f;
    public float SpawnRate = 0;
    bool spawn = true;

    float SpawnTimer = 0f;
             
    void Update()
    {
        float randOil = Random.value;
        int randSpawnPoint = Random.Range(1, SpawnPoint.Length - 1);
        float randRotation = Random.Range(0, 0);
        int counter = 0;


        if (SpawnTimer <= SpawnRate && spawn == true)
        {
            SpawnTimer += Time.deltaTime;
        }     
        
        else if (SpawnTimer >= SpawnRate && spawn == true)
        {
            SpawnTimer = 0;

            if (randOil <= RealOilChance)
            {
                Instantiate(OilPrefabs[0], SpawnPoint[randSpawnPoint].position, Quaternion.Euler(0, 0, randRotation));
                counter++;
            }

            else if (counter == 5)
            {
                Instantiate(OilPrefabs[1], SpawnPoint[randSpawnPoint].position, Quaternion.Euler(0, 0, randRotation));
                counter = 0;
            }

            else if (randOil > RealOilChance)
            {
                Instantiate(OilPrefabs[1], SpawnPoint[randSpawnPoint].position, Quaternion.Euler(0, 0, randRotation));
                counter = 0;
            }

        }

        
    }

    public void StopSpawning()
    {
        spawn = false;
    }

}
