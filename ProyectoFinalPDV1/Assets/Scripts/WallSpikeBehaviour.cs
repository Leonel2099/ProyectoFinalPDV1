using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpikeBehaviour : MonoBehaviour
{
    public Transform[] checkPointWall;
    public float speed = 2.5f;

    int currentPosition = 0;
    int nextPosition = 1;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, checkPointWall[nextPosition].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, checkPointWall[nextPosition].position) <= 0)
        {
            currentPosition = nextPosition;
            nextPosition++;

            if (nextPosition > checkPointWall.Length - 1)
                nextPosition = 0;
        }

    }

}

