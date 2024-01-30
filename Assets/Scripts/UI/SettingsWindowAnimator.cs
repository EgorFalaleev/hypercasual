using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsWindowAnimator : MonoBehaviour
{
    [SerializeField] private float _openAnimationTimeInSeconds = 1f;
    [SerializeField] private float _closeAnimationTimeInSeconds = 1f;

    void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void OpenSettings()
    {
        transform.LeanScale(Vector2.one, _openAnimationTimeInSeconds);
    }

    public void CloseSettings()
    {
        transform.LeanScale(Vector2.zero, _closeAnimationTimeInSeconds);
    }
}
