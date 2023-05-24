using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public int Score
    {
        get; private set;
    }
    private void Awake()
    {
        if (instance != null) Debug.LogError("스코어 매지너가 좆됐음");
        instance= this;
    }
    public void ScoreUp(int amount)
    {
        score += amount;
    }
}
