using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{

    private static UIControl instance;

    [SerializeField] private TMPro.TMP_Text pointText;

    private int currentScore;

    private void Start()
    {
        instance = this;
    }

    private void UpdateScore(int deltaScore)
    {
        currentScore += deltaScore;
    }

    private void UpdateUI()
    {
        pointText.text = $"Score {currentScore}";
    }

    public static void AddScore(int score)
    {
        instance.UpdateScore(score);
        instance.UpdateUI();
    }
}
