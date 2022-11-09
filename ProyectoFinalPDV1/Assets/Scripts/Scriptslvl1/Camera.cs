using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float Sensitivity = 100f;

    public Transform player1;

    float xRotation = 0f;
    // Start is called before the first frame update
    // Todo lo que queremos que se ejecute 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    // Lo que se llama cada frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -25f, 40f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player1.Rotate(Vector3.up * mouseX);
    }
}
