using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardEffect : MonoBehaviour
{
    void LateUpdate()
    {
        Vector3 targetDirection = Vector3.zero;
        targetDirection = Camera.main.transform.forward;
        transform.LookAt(transform.position + targetDirection);
    }
}
