using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAudioController : MonoBehaviour
{
    [SerializeField] private Toggle _musicToggle;
    [SerializeField] private Toggle _effectsToggle;

    private void Start()
    {
        _musicToggle.isOn = SaveManager.Instance.IsMusicOn == 1 ? true : false;
        _effectsToggle.isOn = SaveManager.Instance.IsEffectsOn == 1 ? true : false;
    }
}
