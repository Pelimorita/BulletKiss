using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
    public GameObject spawnItem;

    public float frequency;

    public float initialSpeed;

    float lastSpawnedTime;

    public Vector3 spawnRange;

    public float objectLifetime = 5f; 




    void Update()
    {
        if(Time.time > lastSpawnedTime + frequency) {
            Spawn();
            lastSpawnedTime = Time.time;
        }
        
    }


    

public void Spawn() {
    Vector3 randomPosition = transform.position + new Vector3(
        Random.Range(-spawnRange.x, spawnRange.x), 
        Random.Range(-spawnRange.y, spawnRange.y), 
        Random.Range(-spawnRange.z, spawnRange.z)
    );

    GameObject newSpawnedObject = Instantiate(spawnItem, randomPosition, Quaternion.identity);
    newSpawnedObject.GetComponent<Rigidbody>().velocity = transform.forward * initialSpeed;
    newSpawnedObject.transform.parent = transform;

    Destroy(newSpawnedObject, objectLifetime); 

}
}