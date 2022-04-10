using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public bool x, y, z;
    public float speed;

    private void Update() {
        //Spin the object depending on what axis the user requested in edit mode
        if (x) transform.Rotate(speed, 0, 0);
        if (y) transform.Rotate(0, speed, 0);
        if (z) transform.Rotate(0, 0, speed);
    }
}

