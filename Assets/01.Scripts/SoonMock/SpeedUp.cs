using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour, IisItem
{
    public float amount;

    public void OnTake()
    {
        Time.timeScale += amount;
    }
}
