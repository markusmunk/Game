using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelControl : MonoBehaviour
{
    public float speedH = 2.0f;
    private float yaw = 0.0f;
    public bool flipModel = false;

    // Update is called once per 0.2 frame
    private void FixedUpdate()
    {
        ModelRotate();
    }

    void ModelRotate()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        if (Input.GetKeyDown(KeyCode.E))
        {
            flipModel = !flipModel;
        }
        if (flipModel)
        {
            transform.eulerAngles = new Vector3(180, 0.0f, 0.0f);
        }
    }
}
