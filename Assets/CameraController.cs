using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float followSpeed;
    public float rotationSpeed;

    public Transform target;
    public Vector3 offset;
    public Vector3 rotationOffset;

    Vector3 velocity;
    Vector3 rotationVelocity;

    private void LateUpdate()
    {
       // transform.position = Vector3.SmoothDamp(transform.position, target.transform.position + offset, ref velocity, followSpeed);
       // transform.eulerAngles = Vector3.SmoothDamp(transform.eulerAngles, target.transform.eulerAngles + rotationOffset, ref rotationVelocity, followSpeed);
    }
}
