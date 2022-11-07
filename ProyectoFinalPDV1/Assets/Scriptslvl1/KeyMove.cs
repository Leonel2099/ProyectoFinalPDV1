using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : Interactable
{
    private float speed = 0.3f;
    private float speedR = 100f;
    private bool active = false;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(0, 0 , speed * Time.deltaTime);
        if (transform.position.y >= 2.5 || transform.position.y <= 2)
        {
            speed *= -1;
        }
        transform.Rotate(Vector3.up * Time.deltaTime* speedR, Space.World);
    }
   
    public override void Interact()
    {
        base.Interact();
        active = true;
        Destroy(gameObject);
    }
}
