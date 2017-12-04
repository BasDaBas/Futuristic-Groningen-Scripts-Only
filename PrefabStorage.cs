using UnityEngine;
using System.Collections;

public class PrefabStorage : MonoBehaviour {
	public GameObject[] originalPrefabs;
	public GameObject[] miniPrefabs;
	public static int prefabCount;
	// Use this for initialization
	void Start () {
		prefabCount = originalPrefabs.Length;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
