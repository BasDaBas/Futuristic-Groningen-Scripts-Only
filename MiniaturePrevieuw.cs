using UnityEngine;
using System.Collections;

public class MiniaturePrevieuw : MonoBehaviour {

    public GameObject clone;
	public Transform miniPosition;
	public int bulletIdentity;

	// Use this for initialization
	void Start () {
		this.transform.parent = miniPosition.transform;
		bulletIdentity = VerhicleController.bulletIdentity;
		CreateClone ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("left")) {
			if(bulletIdentity != 0)
			{
				bulletIdentity = VerhicleController.bulletIdentity;
				CreateClone ();
			}
		} else if (Input.GetButtonDown ("right")) {
			if (bulletIdentity != PrefabStorage.prefabCount) {
				bulletIdentity = VerhicleController.bulletIdentity;
				CreateClone ();
			}
		}
	}
	void CreateClone()
	{
		Destroy (clone);
		Debug.Log ("This is object number"+VerhicleController.bulletIdentity);
		GameObject prefab = GameObject.Find ("prefabStorage");
		PrefabStorage prefabStorage = prefab.GetComponent<PrefabStorage> ();
		clone = Instantiate (prefabStorage.miniPrefabs [bulletIdentity], miniPosition.position, Quaternion.identity) as GameObject;
		clone.transform.parent = transform;
	}
}
