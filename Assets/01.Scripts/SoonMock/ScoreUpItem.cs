using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpItem : MonoBehaviour, IisItem
{
    public int amount;
    public void OnTake()
    {
        ScoreManager.instance.ScoreUp(amount);
        Destroy(gameObject);
    }
}
