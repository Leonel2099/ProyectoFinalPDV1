using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Interactable
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.GetComponent<Animator>().SetTrigger("AttackT");
        }
    }
}
