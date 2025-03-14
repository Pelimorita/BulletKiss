using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public int pointsToAdd = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //PointsText.points += pointsToAdd;
        }
    }
}
