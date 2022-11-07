using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //--------------Variables----------------//
    public float alertRange;
    public LayerMask playerCape;
    private bool bewareAlert;
    public Transform player;
    public float speed = 2f;
    //--------------------------------------//



    void Update()
    {
        bewareAlert = Physics.CheckSphere(transform.position, alertRange, playerCape); // con esto creo una esfera invisible 
        if (bewareAlert == true) // si pasa por el rango
        {
            Vector3 posPlayer = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(posPlayer);
            transform.position = Vector3.MoveTowards(transform.position, posPlayer, speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos() // muestra el rango del enemigo

    {
        Gizmos.color = Color.yellow; // color de la malla 
        Gizmos.DrawWireSphere(transform.position, alertRange); // dibuja la malla de la esfera
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyBall")
        {
            Destroy(gameObject);
        }
    }
}
