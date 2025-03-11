using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [Header("Life Bar")]
    [SerializeField] private int value1;
    [SerializeField] private int maxLife = 100;
    public UnityEngine.UI.Image life;

    private void Start()
    {
        value1 = PlayerMovement.actualLife;
    }
    void Update()
    {
        life.fillAmount = value1 / maxLife;
    }
}
