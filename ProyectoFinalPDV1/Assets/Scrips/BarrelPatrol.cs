using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelPatrol : MonoBehaviour
{
    [SerializeField] private GameObject barrel;
    [SerializeField] private Transform[] checkPoints;
    [SerializeField] private float vel = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("makeMovement");
       
    }

    // Update is called once per frame
    void Update()
    {

  
    }

    IEnumerator makeMovement()
    {
        for (int i = 1; i < checkPoints.Length; i++)
        {
            Vector3 newPosition = new Vector3(checkPoints[i].position.x, barrel.transform.position.y, checkPoints[i].position.z);
            while (barrel.transform.position != checkPoints[i].position)
            {
                barrel.transform.position = Vector3.MoveTowards(barrel.transform.position, checkPoints[i].transform.position, vel * Time.deltaTime);
                yield return null;
            }
            //StartCoroutine("makeMovement");
            //if (i == checkPoints.Length - 1)
            //{
            //    yield break;
            //}
            //yield return StartCoroutine("rotationBarrel");
        }
    }
}
