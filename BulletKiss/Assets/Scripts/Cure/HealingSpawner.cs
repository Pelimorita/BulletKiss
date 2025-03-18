using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealinSpawner : MonoBehaviour
{
    public GameObject spawnItem; 
    public float frequency; 
    public float initialSpeed; 
    public float objectLifetime; 
    public Vector3 spawnRange; 
    

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, frequency);
    }

    public void Spawn()
    {
        Vector3 spawnPosition;

        
            spawnPosition = transform.position + new Vector3(
                Random.Range(-spawnRange.x, spawnRange.x),
                Random.Range(-spawnRange.y, spawnRange.y),
                Random.Range(-spawnRange.z, spawnRange.z)
            );
        


        GameObject newSpawnedObject = Instantiate(spawnItem, spawnPosition, Quaternion.identity);
        

        Destroy(newSpawnedObject, objectLifetime); 
    }
}
