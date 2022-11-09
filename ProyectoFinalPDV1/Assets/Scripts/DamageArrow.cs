using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArrow : MonoBehaviour
{
    private int  life = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boss"))
        {
            life += 1;
            if(life == 5)
            {
                Destroy(gameObject);
            }
        }
    }
}
