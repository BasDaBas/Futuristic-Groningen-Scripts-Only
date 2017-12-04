using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    bool secondPersonLook = false;

    void Update()
    {
        if (secondPersonLook == true && Input.GetButtonDown("B Button"))
        {
            secondPersonLook = false;
            Debug.Log("secondPersonLook = false");
        }
        else if (secondPersonLook == false && Input.GetButtonDown("B Button"))
        {
            secondPersonLook = true;
            Debug.Log("secondPersonLook = true");
        }

        if (secondPersonLook == true)
        {
			float translationRight = Input.GetAxis("RightTrigger") * speed;
            float translationLeft = Input.GetAxis("LeftTrigger") * speed;

            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            translationRight *= Time.deltaTime;
            translationLeft *= Time.deltaTime;
            rotation *= Time.deltaTime;
            transform.Translate(0, 0, translationRight);//transform forward
            transform.Translate(0, 0, -translationLeft);//transform backward
            transform.Rotate(0, rotation, 0);
        }


    }
}