using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //-----------------------------------------//
    public GameObject coinPoint;
    public float receives;
    //-----------------------------------------//

    private void Update()
    {
        transform.Rotate(0, 60 * Time.deltaTime, 0);  // La moneda va a girar 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // si player pasa por la moneda
        {
            coinPoint.GetComponent<ScoreCoins>().score += receives;
            Destroy(gameObject);
        }

    }
}
