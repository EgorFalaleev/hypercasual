using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public UnityEvent OnScoreModified;

    public int Score { get; private set; }
    public int HighScore { get; private set; }

    private void Start()
    {
        Score = 0;
        HighScore = SaveManager.Instance.HighScore;
    }

    public void ModifyScore(int amount)
    {
        Score += amount;
        OnScoreModified.Invoke();
    }

    public void SetHighScore()
    {
        if (Score > HighScore)
        {
            HighScore = Score;
            SaveManager.Instance.SaveGameStats();
        }
    }
}
