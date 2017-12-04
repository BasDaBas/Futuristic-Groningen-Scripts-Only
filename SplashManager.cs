using UnityEngine;
using System.Collections;

public class SplashManager : MonoBehaviour {

    // Use this for initialization
    public float autoLoadNextLevelAfter;

    void start()
    {
        Invoke("Test", autoLoadNextLevelAfter);
    }

    void Test () {
        Debug.Log("Test2");
	}
}
