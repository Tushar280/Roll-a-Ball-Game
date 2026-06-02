using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
        // Prevents the enemy from trying to occupy the exact same space as the player
        if (navMeshAgent != null)
        {
            navMeshAgent.stoppingDistance = 1.2f; 
        }
    }

    void Update()
    {
        if(player != null && navMeshAgent != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }
}
