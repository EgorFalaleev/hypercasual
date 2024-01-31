using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderController : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private ButtonsController _buttonsController;

    private void Start()
    {
        _buttonsController = FindObjectOfType<ButtonsController>();
        _slider.onValueChanged.AddListener(val => _buttonsController.ChangeMasterVolume(val));
    }

    public void UpdateSlider()
    {
        _slider.value = _buttonsController.MasterVolume;
    }
}
