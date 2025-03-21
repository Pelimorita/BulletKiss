using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnFollowManager : MonoBehaviour
{
    #region VARIABLES
    [Header("Control del tiempo de spawn")]
    [SerializeField] private float timeToSpawn = 2f; //Tiempo en el que spawnear� cada enemigo
    [SerializeField] private float timeIncrement = 1; //Incremento del tiempo
    [SerializeField] private float initialSpeedSpawn = 0; //Donde inicia a contar el tiempo

    [Header("Control de apariciones del spawn")]
    [SerializeField] private GameObject spawnPrefab; //Lo que va a spawnear
    [SerializeField] private Transform parentObject; //El spawn
    

    [Header("Radio del spawn")]
    [SerializeField] private float minLimit = -5;//Posicion minima del vector inicial
    [SerializeField] private float maxLimit = 5;//posicion m�xima del vector inicial
    #endregion

    void Update()
    {
        initialSpeedSpawn += timeIncrement * Time.deltaTime;//Controlamos el tiempo

        if(timeIncrement > 10)
        {
            if (initialSpeedSpawn > timeToSpawn ) //si el tiempo inicial es mayor al de spawneo saldr� un enemigo
            {
                Vector3 posAppear = randomPositionSpawn();
                Instantiate(spawnPrefab, posAppear, Quaternion.identity, parentObject); 
                initialSpeedSpawn = 0;
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
