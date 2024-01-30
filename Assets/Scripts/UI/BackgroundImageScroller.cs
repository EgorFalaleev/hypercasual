using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundImageScroller : MonoBehaviour
{
    [SerializeField] private RawImage _backgroundImage;
    [SerializeField] private float _speed;

    private void Update()
    {
        _backgroundImage.uvRect = new Rect(_backgroundImage.uvRect.position + new Vector2(0, _speed) * Time.deltaTime, _backgroundImage.uvRect.size);
    }
}
