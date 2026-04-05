using UnityEngine;
using UnityEngine.AI;

public class NPCFollow : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < 10f)
        {
            agent.SetDestination(player.position);
        }
    }
}