using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public UnityEvent OnScoreModified;

    public int Score {  get; private set; }

    public void ModifyScore(int amount)
    {
        Score += amount;
        OnScoreModified.Invoke();
    }
}
