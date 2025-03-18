using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingSpawner : MonoBehaviour
{
    public GameObject spawnItem; // Objeto que se spawnea (cura)
    public float frequency = 0.2f; // Frecuencia de aparición  no quiero que aparezca lo de spawn positions que te mostré en la imagen 
    public float initialSpeed = 0f; // Velocidad inicial
    public float objectLifetime = 5f; // Tiempo de vida antes de desaparecer
    public Vector3 spawnRange; // Rango de posiciones aleatorias

    public List<Transform> spawnPositions; // Lista de posiciones en el mapa

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, frequency); // Llamar a Spawn cada "frequency" segundos
    }

    public void Spawn()
    {
        Vector3 spawnPosition;

        if (spawnPositions.Count > 0)
        {
            // Seleccionar una posición aleatoria de la lista
            int index = Random.Range(0, spawnPositions.Count);
            spawnPosition = spawnPositions[index].position;
        }
        else
        {
            // Generar una posición aleatoria dentro del rango
            spawnPosition = transform.position + new Vector3(
                Random.Range(-spawnRange.x, spawnRange.x),
                Random.Range(-spawnRange.y, spawnRange.y),
                Random.Range(-spawnRange.z, spawnRange.z)
            );
        }

        GameObject newSpawnedObject = Instantiate(spawnItem, spawnPosition, Quaternion.identity);
        if (newSpawnedObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            rb.velocity = transform.forward * initialSpeed;
        }

        Destroy(newSpawnedObject, objectLifetime); // Eliminar después de X segundos
    }
}