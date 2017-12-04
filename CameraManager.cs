using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

    public Camera camera1;
    public Camera camera2;

    public GameObject player1;

    
	// Use this for initialization
	void Start ()
    {
        camera1.enabled = true;
        camera2.enabled = false;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("B Button"))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}
