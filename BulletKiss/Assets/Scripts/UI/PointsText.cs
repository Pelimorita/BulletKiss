using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsText : MonoBehaviour
{
    public static int points = 0;
    public TMP_Text score;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            points += 50;
            timer = 0;
        }
        score.text = points.ToString();
    }
}
