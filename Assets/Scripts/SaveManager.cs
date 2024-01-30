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

    public void SaveGameStats()
    {
        PlayerPrefs.SetInt("HighScore", FindObjectOfType<ScoreController>().HighScore);
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat("MasterVolume", SoundManager.Instance.Volume);
        // 1 - turned on, 0 - turned off
        PlayerPrefs.SetInt("IsMusicOn", SoundManager.Instance.IsMusicOn);
        PlayerPrefs.SetInt("IsEffectsOn", SoundManager.Instance.IsEffectsOn);
    }
}
