using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyIA : MonoBehaviour
{
    [Header("Configuracion de la IA")]
    [SerializeField] private float radiusMovement = 7f;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();//le dice que ese componente es del enemigo
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f) 
        {
            randomDestination();
        }
    }

    void randomDestination() 
    {
        //El insideUnitSphere te da un valor random de un vecto(x,y,z)
        Vector3 randomDirection = Random.insideUnitSphere * radiusMovement;
        randomDirection = randomDirection + transform.position;
        NavMeshHit hit;

        if (NavMesh.SamplePosition(randomDirection, out hit, radiusMovement, NavMesh.AllAreas)) 
        {
            targetPosition = hit.position;
            agent.SetDestination(targetPosition);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radiusMovement);
    }
}
