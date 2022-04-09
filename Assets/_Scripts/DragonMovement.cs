using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    public static float speed = 10.0f;
    public GameObject model; 
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    private void FixedUpdate()
    {
        // Make speed a constant
        rb.velocity = rb.velocity.normalized * speed;
        // Look towards forward
        model.transform.rotation = Quaternion.LookRotation(rb.velocity) ;
    }
}
