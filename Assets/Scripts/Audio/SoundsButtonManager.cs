using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoundsButtonManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _musicText;
    [SerializeField] private TMP_Text _effectText;

    public void SetSoundsButtonText()
    {
        _musicText.text = $"Music {SaveManager.Instance.IsMusicOn}";
        _effectText.text = $"Effects {SaveManager.Instance.IsEffectsOn}";
    }
}
