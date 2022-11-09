using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    [SerializeField]
    private GameObject grid;
    private Animator animaitor;
    private Animator animaitorGrid;
    private bool active = false;
    private bool lever = false;
    void Start()
    {
        animaitorGrid = grid.GetComponent<Animator>();
        animaitor = GetComponent<Animator>();
    }

    void Update()
    {

        animaitor.SetBool("Active", active);
        
        if (active)
        {
            lever = true;
        }
        animaitorGrid.SetBool("Open", lever);
    }
    public override void Interact()
    {
        base.Interact();
        active = true;
    }
}
