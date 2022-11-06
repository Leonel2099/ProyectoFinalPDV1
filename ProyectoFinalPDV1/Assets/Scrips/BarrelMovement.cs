using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BarrelMovement : MonoBehaviour
{
    [SerializeField]
    Transform destination;
    NavMeshAgent NavMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent = this.GetComponent<NavMeshAgent>();

        if(NavMeshAgent == null)
        {
            Debug.LogError("nav mesh agent comp is not attached to" + gameObject.name);
        }
        else
        {
            setDestination();
        }
    }

    private void setDestination()
    {
        if(destination != null)
        {
            Vector3 targetVector = destination.transform.position;
            NavMeshAgent.SetDestination(targetVector);
        }    
    }
}
