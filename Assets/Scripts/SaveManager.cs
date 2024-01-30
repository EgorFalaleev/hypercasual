using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;

    public int HighScore { get { return PlayerPrefs.GetInt("HighScore", 0); }
        private set { }
    }
    public float MasterVolume
    {
        get { return PlayerPrefs.GetFloat("MasterVolume", 0.5f); }
        private set { }
    }
    // 1 - music on, 0 - music off
    public int IsMusicOn
    {
        get { return PlayerPrefs.GetInt("IsMusicOn", 1); }
        private set { }
    }
    public int IsEffectsOn
    {
        get { return PlayerPrefs.GetInt("IsEffectsOn", 1); }
        private set { }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    public void Save()
    {
        SaveGameStats();
        SaveSoundSettings();
    }

    public void SaveGameStats()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat("MasterVolume", 0.5f);
        // 1 - turned on, 0 - turned off
        PlayerPrefs.SetInt("IsMusicOn", 1);
        PlayerPrefs.SetInt("IsEffectsOn", 1);
    }
}
