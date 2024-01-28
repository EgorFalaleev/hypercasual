using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUIController : MonoBehaviour
{
    [SerializeField] private Image[] _heartImages;
    [SerializeField] private Sprite _fullHeartImage;
    [SerializeField] private Sprite _emptyHeartImage;

    public void SetHeartImages(PlayerHealthController playerHealthController)
    {
        // first fill all images with empty hearts
        foreach (var image in _heartImages)
        {
            image.sprite = _emptyHeartImage;
        }

        // then set full heart images depending on HP
        for (int i = 0; i < playerHealthController.GetHealth(); i++)
        {
            _heartImages[i].sprite = _fullHeartImage;
        }
    }
}
