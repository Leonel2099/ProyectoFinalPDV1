using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBehaviour : MonoBehaviour
{
   // private float speed;
    // Update is called once per frame
    void Update()
    {
     //   transform.Translate(0, 0, speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, -70f, 0) * Time.deltaTime);
    }
}
