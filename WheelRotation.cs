using UnityEngine;
using System.Collections;

public class WheelRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(Vector3.up, Time.fixedDeltaTime * 400);
	}
}
