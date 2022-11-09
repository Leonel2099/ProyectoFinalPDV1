using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 10;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        if (characterController.isGrounded)
        {
            moveVelocity = transform.forward * vInput+transform.right* hInput;
            moveVelocity *= speed;
            //turnVelocity = transform.up * rotationSpeed * hInput;
            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
                AudioManager.JumpPlayerSound();
            }
        }
        //Adding gravity
        moveVelocity.y -= gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        //transform.Rotate(turnVelocity * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spike")
        {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "PassLevel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.gameObject.tag == "Lava")
        {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Rehen")
        {
            SceneManager.LoadScene("YouWon");
            
        }

    }
}