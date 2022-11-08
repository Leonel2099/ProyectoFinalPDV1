using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWhitFloor : MonoBehaviour
{
    CharacterController player;
    Vector3 groundPos;
    Vector3 lastGroundPos;
    string groundName;
    string lastGroundName;
    void Start()
    {
        player = this.GetComponent<CharacterController>();
    }
    void Update()
    {
        if (player.isGrounded)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 3, LayerMask.GetMask("Platform")))
            {
                GameObject groundedIn = hit.collider.gameObject;
                groundName = groundedIn.name;
                groundPos = groundedIn.transform.position;

                if (groundPos != lastGroundPos && groundName == lastGroundName)
                {
                    this.transform.position += groundPos - lastGroundPos;
                    player.enabled = false;
                    player.transform.position = this.transform.position;
                    player.enabled = true;


                }
                lastGroundName = groundName;
                lastGroundPos = groundPos;
            }
        }
        else if (!player.isGrounded)
        {
            lastGroundName = null;
            lastGroundPos = Vector3.zero;
        }
    }
    void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void OnDrawGizmos()
    {
        player = this.GetComponent<CharacterController>();
        Gizmos.DrawRay(transform.position, Vector3.down*3);
    }
}
