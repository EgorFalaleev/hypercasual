using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    [SerializeField] private int _scoreAmount;

    private ScoreController _scoreController;

    private void Awake()
    {
        _scoreController = FindObjectOfType<ScoreController>();
    }

    public void ModifyScore()
    {
        _scoreController.ModifyScore(_scoreAmount);
    }
}
