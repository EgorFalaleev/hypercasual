using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSoundController : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    public void PlayEffectSound()
    {
        SoundManager.Instance.PlayEffectSound(_clip);
    }
}
