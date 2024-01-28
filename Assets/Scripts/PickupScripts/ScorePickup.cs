using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : ScoreObject, IPickup
{
    public void ApplyEffect()
    {
        ModifyScore();
    }
}
