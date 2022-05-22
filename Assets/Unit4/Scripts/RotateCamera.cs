using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float axisRotationSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal") * axisRotationSpeed;
        float mInput = Input.GetAxis("Mouse X");

        float input = hInput != 0 ? hInput : mInput;

        transform.Rotate(Vector3.up * input * Time.deltaTime);
    }
}
