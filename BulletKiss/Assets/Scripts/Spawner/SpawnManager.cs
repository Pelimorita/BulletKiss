using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Control del tiempo de spawn")]
    [SerializeField] private float timeToSpawn = 2f; //Tiempo en el que spawneará cada enemigo
    [SerializeField] private float timeIncrement = 1; //Incremento del tiempo
    [SerializeField] private float initialSpeedSpawn = 0; //Donde inicia a contar el tiempo

    [Header("Control de apariciones del spawn")]
    [SerializeField] private GameObject spawnPrefab; //Lo que va a spawnear
    [SerializeField] private Transform parentObject; //El spawn
    [SerializeField] private bool flagControl = true;//Solo para probar el navigator
    [SerializeField] private int controlAppear = 0;//Solo para probar el navigator

    [Header("Radio del spawn")]
    [SerializeField] private float minLimit = -7;//Posicion minima del vector inicial
    [SerializeField] private float maxLimit = 7;//posicion máxima del vector inicial
   
    void Update()
    {
        initialSpeedSpawn += timeIncrement * Time.deltaTime;//Controlamos el tiempo

        if (initialSpeedSpawn > timeToSpawn && flagControl == true) //si el tiempo inicial es mayor al de spawneo saldrá un enemigo
        {
            Vector3 posAppear = randomPositionSpawn();
            Instantiate(spawnPrefab, posAppear, Quaternion.identity, parentObject); 
            controlAppear++;
            initialSpeedSpawn = 0;

            if (controlAppear > 5) 
            {
                flagControl = false;               
            }
        }
    }

    public Vector3 randomPositionSpawn() 
    {
        //Generamos un vector random para la posicion de spawn de los enemigos
       Vector3 position = new Vector3(Random.Range(minLimit, maxLimit), 1, Random.Range(minLimit, maxLimit));
       return position;
    }
}
