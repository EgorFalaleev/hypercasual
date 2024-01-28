using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float _scrollingSpeed = 0.1f;
    [SerializeField] private Renderer _renderer;

    private void Update()
    {
        _renderer.material.mainTextureOffset += new Vector2(0, _scrollingSpeed * Time.deltaTime);
    }
}
