using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public float Volume { get; private set; }
    public string IsMusicOn { get; private set; }
    public string IsEffectsOn { get; private set; }

    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private AudioSource _effectSource;

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

    private void Start()
    {
        IsMusicOn = SaveManager.Instance.IsMusicOn;
        IsEffectsOn = SaveManager.Instance.IsEffectsOn;
        Volume = SaveManager.Instance.MasterVolume;
        _musicSource.mute = SaveManager.Instance.IsMusicOn == "On" ? false : true;
        _effectSource.mute = SaveManager.Instance.IsEffectsOn == "On" ? false : true;
        ChangeMasterVolume(SaveManager.Instance.MasterVolume);
    }

    public void PlayEffectSound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }

    public void ChangeMasterVolume(float value)
    {
        Volume = value;
        _musicSource.volume = value;
        _effectSource.volume = value;
    }

    public void ToggleEffects()
    {
        _effectSource.mute = !_effectSource.mute;

        IsEffectsOn = _effectSource.mute ? "Off" : "On";
    }

    public void ToggleMusic()
    {
        _musicSource.mute = !_musicSource.mute;

        IsMusicOn = _musicSource.mute ? "Off" : "On";
    }
}
