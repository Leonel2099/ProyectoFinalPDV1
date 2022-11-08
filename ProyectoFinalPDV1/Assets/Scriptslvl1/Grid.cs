using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : Interactable
{
    private Animator animaitor;
    private bool active = false;
    void Start()
    {
        animaitor = GetComponent<Animator>();
    }

    void Update()
    {
        animaitor.SetBool("Open", active);
    }
    public override void Interact()
    {
        base.Interact();
        active = true;
    }
}
