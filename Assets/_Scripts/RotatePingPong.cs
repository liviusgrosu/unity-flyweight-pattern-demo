using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePingPong : MonoBehaviour
{
    public float Angle;
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(-90 + -Mathf.PingPong(Time.time * Speed, Angle), 0, -90); 
    }
}
