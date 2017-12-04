using UnityEngine;
using System.Collections;

public class MiniatureRotation : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime);
	}
}
