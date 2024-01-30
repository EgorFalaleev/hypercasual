using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatWindow : MonoBehaviour
{
    [SerializeField] private Transform _windowTransform;
    [SerializeField] private CanvasGroup _background;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _background.alpha = 0f;
        _background.LeanAlpha(1f, 0.5f);

        _windowTransform.localPosition = new Vector2(0, -Screen.height);
        _windowTransform.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(SceneIndexes.MAIN_MENU);
    }
}
