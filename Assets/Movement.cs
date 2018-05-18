using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.A))
        {
            Quaternion newRoataion = Quaternion.Euler(Vector3.up * -90);
            newRoataion = Quaternion.LookRotation(transform.forward);
            transform.rotation = newRoataion;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion newRoataion = Quaternion.Euler(Vector3.up * 90);
            newRoataion = Quaternion.LookRotation(transform.forward);
            transform.rotation = newRoataion;
        }
    }
}
