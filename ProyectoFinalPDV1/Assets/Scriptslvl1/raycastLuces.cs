using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastLuces : MonoBehaviour
{
    private Transform ray;
    public float distance;
    [SerializeField]
    private GameObject player;
    private float vel = 10;
    // Start is called before the first frame update
    void Start()
    {
        ray = transform.Find("Ray");
    }

    // Update is called once per frame
    void Update()
    {
        rayLight();
    }
    public void rayLight()
    {
        RaycastHit hit;
        if (Physics.Raycast(ray.position, ray.forward, out hit, distance, LayerMask.GetMask("Player")))
        {
            Debug.Log(hit.transform.name);
            Debug.DrawRay(ray.position, ray.forward * distance * 2, Color.red);
            GameObject.Destroy(player);
        }
        else
        {
            Debug.DrawRay(ray.position, ray.forward * distance, Color.green);
        }
    }
}
