using Firebase.Analytics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoggingBehaviour : MonoBehaviour
{
    void Start()
    {
        FirebaseAnalytics.LogEvent(FirebaseAnalytics.EventLevelStart);
    }

    private void OnDestroy()
    {
        FirebaseAnalytics.LogEvent(FirebaseAnalytics.EventLevelEnd);
    }
}
