using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    private SoundManager _soundManager;
    private SaveManager _saveManager;
    
    public float MasterVolume {  get; private set; }

    void Start()
    {
        _soundManager = FindObjectOfType<SoundManager>();
        _saveManager = FindObjectOfType<SaveManager>();
        MasterVolume = _saveManager.MasterVolume;
    }

    public void ToggleMusic()
    {
        _soundManager.ToggleMusic();
    }

    public void ToggleEffects()
    {
        _soundManager.ToggleEffects();
    }

    public void ChangeMasterVolume(float value)
    {
        _soundManager.ChangeMasterVolume(value);
    }

    public void SaveSoundSettings()
    {
        _saveManager.SaveSoundSettings();
    }
}
