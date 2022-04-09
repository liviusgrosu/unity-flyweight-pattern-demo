using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    public static float speed = 5.0f;
    public GameObject model; 
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    private void FixedUpdate()
    {
        model.transform.rotation = Quaternion.LookRotation(rb.velocity) ;
    }
}
