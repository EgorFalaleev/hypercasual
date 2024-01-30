using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public float Volume { get; private set; }
    public int IsMusicOn { get; private set; }
    public int IsEffectsOn { get; private set; }

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

    public void PlayEffectSound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }

    public void ChangeMasterVolume(float value)
    {
        Volume = value;
        AudioListener.volume = value;
    }

    public void ToggleEffects()
    {
        _effectSource.mute = !_effectSource.mute;

        IsEffectsOn = _effectSource.mute ? 0 : 1;
    }

    public void ToggleMusic()
    {
        _musicSource.mute = !_musicSource.mute;

        IsMusicOn = _musicSource.mute ? 0 : 1;
    }
}
