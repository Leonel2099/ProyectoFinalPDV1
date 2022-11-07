using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    private Animator animaitor;
    private bool active=false;
    // Start is called before the first frame update
    void Start()
    {
        animaitor = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        animaitor.SetBool("Active", active);
    }
    public override void Interact()
    {
        base.Interact();
        active = true;
    }
}
