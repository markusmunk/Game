using UnityEngine;
using System.Collections;

public class FirstPersonCam : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float minPitch = -75f;
    private float maxPitch = 50f;

    bool cameraFlipped = false;

    void FixedUpdate()
    {
        CameraRotate();
        CameraFlip();
    }

    void CameraRotate()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        
    }

    void CameraFlip()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cameraFlipped = !cameraFlipped;
        }

        if (cameraFlipped)
        {
            transform.eulerAngles = new Vector3(-pitch, -yaw, 180);
        }
    }
}
