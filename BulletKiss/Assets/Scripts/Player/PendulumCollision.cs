using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumCollision : MonoBehaviour
{
    [Header("Push Pendulum")]
    [SerializeField] private float pushForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if (rigidbody != null)
        {
            Vector3 pushForceDirection = hit.gameObject.transform.position - transform.position;
            pushForceDirection.y = 0;
            pushForceDirection.Normalize();
            rigidbody.AddForce(pushForceDirection * pushForce, ForceMode.Impulse);
        }
    }
}
