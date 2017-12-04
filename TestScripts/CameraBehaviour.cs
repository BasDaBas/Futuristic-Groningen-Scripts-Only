using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += speedH * Input.GetAxis("RightJoystickX");
        pitch -= speedV * Input.GetAxis("RightJoystickY");

        transform.eulerAngles = new Vector3(pitch, -yaw, 0.0f);
    }
}
