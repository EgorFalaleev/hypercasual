using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    public string IsMusicOn
    {
        get { return PlayerPrefs.GetString("IsMusicOn", "On"); }
        private set { }
    }
    public string IsEffectsOn
    {
        get { return PlayerPrefs.GetString("IsEffectsOn", "On"); }
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

    public void SaveGameStats()
    {
        PlayerPrefs.SetInt("HighScore", FindObjectOfType<ScoreController>().HighScore);
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat("MasterVolume", SoundManager.Instance.Volume);
        // 1 - turned on, 0 - turned off
        PlayerPrefs.SetString("IsMusicOn", SoundManager.Instance.IsMusicOn);
        PlayerPrefs.SetString("IsEffectsOn", SoundManager.Instance.IsEffectsOn);
    }
}
