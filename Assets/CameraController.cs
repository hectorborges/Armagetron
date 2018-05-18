using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float followSpeed;
    public Transform target;
    public Vector3 offset;

    Vector3 velocity;

    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.transform.position + offset, ref velocity, followSpeed);
    }
}
