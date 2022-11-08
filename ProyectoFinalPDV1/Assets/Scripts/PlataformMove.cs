using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformMove : MonoBehaviour
{
    public float plataformSpeed = 2;
    public GameObject[] waypoint; //puntos que va a recorrer
    private int waypointIndex = 0;
    void Update()
    {
        MovePlataform();
    }

    void MovePlataform()
    {
        //este metodo (Vector3.Distance) lo que hace es comprobar la distancia de mi plataforma y el punto que especifique
        // esta linea lo que hara sera comparar la distancia que hay de la plataforma al punto que me dirijo y de ser menor a 0,1 entonces se cumple la siguiente condicion
        if (Vector3.Distance(transform.position, waypoint[waypointIndex].transform.position) < 0.1f)
        {
            waypointIndex++;
            if (waypointIndex >= waypoint.Length)
            {
                waypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoint[waypointIndex].transform.position, plataformSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
