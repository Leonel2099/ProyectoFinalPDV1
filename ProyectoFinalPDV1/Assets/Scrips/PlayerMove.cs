using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    //-----------------------------------------//
    public Camera Cam;
    Rigidbody rb;

    public float mouseHorizontal = 3f;
    public float mouseVertical = 2f;

    float h_mouse;
    float v_mouse;

    public float moveSpeed = 5;
    public float runSpeed = 8;

    float h;
    float v;

    bool floorDetected = false;
    bool isJump = false;
    public float jumpForce = 5.0f;

    //-----------------------------------------//

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Move();

    }

    void Move()
    {
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse = mouseVertical * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h_mouse, 0);
        Cam.transform.Rotate(-v_mouse, 0, 0);

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v);

        if (Input.GetButton("Fire3"))
            transform.Translate(direction * runSpeed * Time.deltaTime);
        else
            transform.Translate(direction * moveSpeed * Time.deltaTime);

        Vector3 floor = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, floor, 1.03f))
        {
            floorDetected = true;
            //print("Contacto con el suelo");
        }
        else
        {
            floorDetected = false;
            //print("No hay contacto con el suelo");
        }

        isJump = Input.GetKeyDown("space");

        if (isJump && floorDetected)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

}
