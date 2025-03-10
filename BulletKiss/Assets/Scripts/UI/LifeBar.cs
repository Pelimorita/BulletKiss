using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [Header("Life Bar")]
    [SerializeField] private int value1;
    [SerializeField] private int value2;
    public UnityEngine.UI.Image life;

    private void Start()
    {
        
    }
    void Update()
    {
        value1 = PlayerController.actualLife;
        value2 = PlayerController.maxLife;
        life.fillAmount = value1 / value2;
    }
}
