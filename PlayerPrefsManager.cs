﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour
{

    const string MASTER_VOLUME_KEY = "master volume";

    public static void SetMasterVolume(float volume)
    {
        if(volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master Volume out of range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
        
    }
}
