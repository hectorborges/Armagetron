using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    bool turning;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.A) && !turning)
        {
            turning = true;
            transform.eulerAngles -= new Vector3(0, 90, 0);

            StartCoroutine(WaitForFrame());
        }

        if (Input.GetKey(KeyCode.D) && !turning)
        {
            turning = true;
            transform.eulerAngles += new Vector3(0, 90, 0);

            StartCoroutine(WaitForFrame());
        }
    }

    IEnumerator WaitForFrame()
    {
        yield return new WaitForSeconds(.25f);
        turning = false;
    }
}
