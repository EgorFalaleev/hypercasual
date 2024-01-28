using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void Start()
    {
        _scoreText.text = "Score: 0";
    }

    public void UpdateScore(ScoreController scoreController)
    {
        _scoreText.text = $"Score: {scoreController.Score}";
    }
}
