using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OneSignalSDK;

public class OneSignalInit : MonoBehaviour
{
    void Start()
    {
        OneSignal.Initialize("c201ce61-8ae2-49b8-8d2e-a5c69eb08975");
    }
}
