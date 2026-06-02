using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
 // Reference to the player's transform.
 public Transform player;

 // Reference to the NavMeshAgent component for pathfinding.
 private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update.
    void Start()
    {
        // Get and store the NavMeshAgent component attached to this object.
        navMeshAgent = GetComponent<NavMeshAgent>();

        // Prevents the enemy from trying to occupy the exact same space as the player
        if (navMeshAgent != null)
        {
            navMeshAgent.stoppingDistance = 1.2f;
        }
    }

    // Update is called once per frame.
    void Update()
    {
        // Safety check: Ensure both the player and the navMeshAgent exist
        if (player != null && navMeshAgent != null)
        {    
            // Set the enemy's destination to the player's current position.
            navMeshAgent.SetDestination(player.position);
        }
    }
}