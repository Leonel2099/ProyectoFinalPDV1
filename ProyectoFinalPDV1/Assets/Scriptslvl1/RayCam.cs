using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCam : MonoBehaviour
{
    private Transform camara;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Raycam");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camara.position, camara.forward * distance, Color.red);
        if (Input.GetButtonDown("Interactable"))
        {
            RaycastHit hit;
            if (Physics.Raycast(camara.position, camara.forward, out hit, distance, LayerMask.GetMask("Lever")))
            {
                Debug.Log(hit.transform.name);
                hit.transform.GetComponent<Interactable>().Interact();
            }
        }

    }
}
