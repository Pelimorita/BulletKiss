using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage = 10f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LifeBar.lifeValue -= damage;
        }
    }/*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LifeBar.lifeValue -= damage;
        }
    }*/
}
