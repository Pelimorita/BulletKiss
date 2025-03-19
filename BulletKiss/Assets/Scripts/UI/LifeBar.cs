using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeBar : MonoBehaviour
{
    [Header("Life Bar")]
    public static float lifeValue = 100f;
    public UnityEngine.UI.Image life;
    void Update()
    {
        lifeValue = Mathf.Clamp(lifeValue, 0, 100);
        life.fillAmount = lifeValue / 100;
    }
}
