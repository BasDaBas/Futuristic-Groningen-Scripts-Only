using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;

    // Use this for initialization
    void Start()
    {   //Checks if there is a musicmanger and if there is one it will get the Volume and set the musicManager volume to that same volume.
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        if (musicManager)
        {
            float volume = PlayerPrefsManager.GetMasterVolume();
            musicManager.SetVolume(volume);

        }

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;// set it to 1 for if you got back from the game
        }

        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
