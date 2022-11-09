using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    //--------------------------------//
    public GameObject arrow;
    private float speedY = 2f;
    //--------------------------------//


    private void Start()
    {
        InvokeRepeating("ShootArow", 0, 3f);
    }


    public void ShootArow()
    {
        Instantiate(arrow, transform.position, transform.rotation);
    }
}
