using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cure : MonoBehaviour
{
    public float cure = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //life = GameObject.Find("Player").GetComponent<LifeBar>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LifeBar.lifeValue += cure;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
