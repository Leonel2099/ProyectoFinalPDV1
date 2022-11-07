using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public float vel = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, vel * Time.deltaTime * (-1));
        if (transform.position.y <= 135 || transform.position.y>=136.2)
        {
            vel *= -1;
        }
        
    }
}
