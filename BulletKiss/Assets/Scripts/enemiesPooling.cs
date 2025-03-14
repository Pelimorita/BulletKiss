using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesPooling : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> enemiesList;
    public int poolSize = 10;


    //Patron singleton para poder acceder a este código desde otros scripts sin necesidad de crear referencias
    private static enemiesPooling instance;
    public static enemiesPooling Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        addEnemies(poolSize);
    }

    private void addEnemies(int amount) 
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject enemies = Instantiate(enemyPrefab);
            enemies.SetActive(false);
            enemiesList.Add(enemies);
            enemies.transform.parent = transform;
        }
    }

    public GameObject RequestEnemy() 
    {
        for (int i = 0; i < enemiesList.Count; i++) 
        {
            if (!enemiesList[i].activeSelf) 
            {
                enemiesList[i].SetActive(true);
                return enemiesList[i];
            }
        }

        return null;
    }
}
