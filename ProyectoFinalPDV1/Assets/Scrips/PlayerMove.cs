using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 20f;

    public void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movment = transform.right * x + transform.forward * z;
        controller.Move(movment * speed * Time.deltaTime);
    }
    ////--------------- Variables-----------------------//
    //public CharacterController controllerPlayer;
    //public float speed = 10f;
    //private float gravity = -9.81f;
    //public Transform groundCheck;
    //public float sphereRadius = 0.3f;
    //public LayerMask groundMask;
    //bool isGrounded;
    //Vector3 velocity;
    //public float jumpHeight = 3;
    ////-----------------------------------------------//
    //void Update()
    //{
    //    isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);
    //    if (isGrounded && velocity.y < 0)
    //    {
    //        Debug.Log("colision");
    //        velocity.y = -2f;
    //    }

    //    float posx = Input.GetAxis("Horizontal");
    //    float posz = Input.GetAxis("Vertical");
    //    Vector3 move = transform.right * posx + transform.forward * posz;

    //    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    //    {
    //        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
    //    }
    //    controllerPlayer.Move(move*speed*Time.deltaTime);
    //    velocity.y += gravity * Time.deltaTime;
    //    controllerPlayer.Move(velocity * Time.deltaTime);
    //}
}
//public class PlayerMove : MonoBehaviour
//{

//    //-----------------------------------------//
//    public Camera Cam;
//    Rigidbody rb;

//    public float mouseHorizontal = 3f;
//    public float mouseVertical = 2f;

//    float h_mouse;
//    float v_mouse;

//    public float moveSpeed = 5;
//    public float runSpeed = 8;

//    float h;
//    float v;

//    bool floorDetected = false;
//    bool isJump = false;
//    public float jumpForce = 5.0f;

//    //-----------------------------------------//

//    void Start()
//    {
//        rb = GetComponent<Rigidbody>();
//        Cursor.lockState = CursorLockMode.Locked;
//    }

//    void Update()
//    {

//        Move();

//    }

//    void Move()
//    {
//        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
//        v_mouse = mouseVertical * Input.GetAxis("Mouse Y");

//        transform.Rotate(0, h_mouse, 0);
//        Cam.transform.Rotate(-v_mouse, 0, 0);

//        h = Input.GetAxis("Horizontal");
//        v = Input.GetAxis("Vertical");

//        Vector3 direction = new Vector3(h, 0, v);

//        if (Input.GetButton("Fire3"))
//            transform.Translate(direction * runSpeed * Time.deltaTime);
//        else
//            transform.Translate(direction * moveSpeed * Time.deltaTime);

//        Vector3 floor = transform.TransformDirection(Vector3.down);

//        if (Physics.Raycast(transform.position, floor, 1.03f))
//        {
//            floorDetected = true;
//            //print("Contacto con el suelo");
//        }
//        else
//        {
//            floorDetected = false;
//            //print("No hay contacto con el suelo");
//        }

//        isJump = Input.GetKeyDown("space");

//        if (isJump && floorDetected)
//        {
//            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
//        }
//    }

//}
