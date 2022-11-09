using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMesh : MonoBehaviour
{
    //--------------- Variables-----------------------//

    public Transform[] destinations;
    public NavMeshAgent navMesh;
    private int i = 0; // punto de inicio 
    [Header("Seguir al jugador")]
    public bool followPlayer;
    private GameObject player;
    private float distanceToPlayer;
    public float distanceToFollowPlayer = 10;
    public float distanceToFollowPath = 2;
    //------------------------------------------------//

    private void Start()
    {
        navMesh.destination = destinations[0].transform.position;
        player = FindObjectOfType<PlayerMove>().gameObject;
    }
    private void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer <= distanceToFollowPlayer)
        {
            FollowPlayer();
        }
        else
        {
            EnemyPath();
        }
    }
    public void EnemyPath()
    {
        navMesh.destination = destinations[i].position;
        if (Vector3.Distance(transform.position, destinations[i].position) <= distanceToFollowPath)
        {
            if (destinations[i] != destinations[destinations.Length - 1])
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }
    }
    public void FollowPlayer()
    {
        navMesh.destination = player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }



}
