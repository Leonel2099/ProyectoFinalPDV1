using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayJump : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpHeigth = 400;
    public bool grounded;
    public LayerMask Mask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }
    }
    public void CheckGround()
    {
        RaycastHit hitinfo = new RaycastHit();
        Debug.DrawRay(transform.position, Vector3.down * 0.6f, Color.green);
        if(Physics.Raycast(transform.position,Vector3.down,out hitinfo, 0.6f, Mask))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpHeigth);
    }
}
