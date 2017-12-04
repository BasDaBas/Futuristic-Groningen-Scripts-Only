using UnityEngine;
using System.Collections;

public class wallBehaviour : MonoBehaviour {
	// Use this for initialization
    void OnTriggerEnter(Collider other)
    {
		GameObject prefab = GameObject.Find ("prefabStorage");
		PrefabStorage prefabStorage = prefab.GetComponent<PrefabStorage> ();

        if (other.gameObject.tag == "Bullet")
        {
			Destroy (this.gameObject);
			Vector3 pos = new Vector3 (other.transform.position.x, 7f, other.transform.position.z);
			Instantiate (prefabStorage.originalPrefabs [VerhicleController.bulletIdentity], pos, Quaternion.identity);
			Debug.Log (VerhicleController.bulletIdentity);

        }
    }
}
