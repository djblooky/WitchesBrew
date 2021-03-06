﻿using TMPro;
using UnityEngine;

public class LevelCompleteText : MonoBehaviour
{
    private TMP_Text textObj;

    private void Start()
    {
        textObj = GetComponent<TMP_Text>();
    }

    private void OnLevelCompleted()
    {
        if (LevelManager.TotalTips >= LevelManager.tipGoal)
        {
            textObj.text = "Level Passed";
        }
        else
        {
            textObj.text = "Level Failed";
            FindObjectOfType<AudioManager>().Play("TimerRing");
        }
    }

    private void OnEnable()
    {
        OrderManager.LevelCompleted += OnLevelCompleted;
    }

    private void OnDisable()
    {
        OrderManager.LevelCompleted -= OnLevelCompleted;
    }
}
