using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class followEnemyIA : MonoBehaviour
{
    #region variables
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform player;
    private float radiusDetected = 4;
    private float radiusMovement = 2;
    private Vector3 pos;
    #endregion
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        if (player != null) 
        {
            float distance = Vector3.Distance(agent.transform.position, player.position);

            if (distance < radiusDetected) 
            {
                agent.SetDestination(player.position);
            }

            ///SUMMARY
            /// Estamos diciendo que si la distancia que se calcula entre el enemigo y el jugador
            ///es mayor al radio de detección que tiene el enemigo y ademas el no agente tiene una ruta pendiente
            ///y además de la ruta pendiente le faltan 0.5cm para llegar a su destino entonces calcule una ruta al azar
            ///SUMARY
            
            if (distance > radiusDetected && !agent.pathPending && agent.remainingDistance < 0.5) 
            {
                randomMove();
            }
        }
    }

    #region Movimiento/detección
    void randomMove() 
    {
        Vector3 randomDirection = Random.insideUnitSphere * radiusMovement;
        randomDirection = randomDirection + transform.position;
        NavMeshHit hit;//punto mas cercano encontrado

        //estamos diciendo que la posicion se va a guardar en una variable llamada hit
        if (NavMesh.SamplePosition(randomDirection, out hit, radiusMovement, NavMesh.AllAreas)) 
        {
            pos = hit.position;
            agent.SetDestination(pos);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radiusDetected);
    }
    #endregion 
}
