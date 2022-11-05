using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpikes : MonoBehaviour
{
    public float vel = 2.5f;
    public bool pared = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, vel * Time.deltaTime, 0);
        if (pared)
        {
            if (transform.position.x <= 193 && transform.position.z >= -45 || transform.position.x >= 196 && transform.position.z <= -48)
            {
                vel *= -1;
            }
        }
        else if(transform.position.x <= 191 && transform.position.z >= -41.3 || transform.position.x >= 194 && transform.position.z <= -44.3)
        {
            vel *= -1;
        }
 

    }
}