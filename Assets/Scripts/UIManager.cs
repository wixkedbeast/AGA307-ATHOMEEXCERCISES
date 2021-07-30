using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{

    public TMP_Text scoreText;
    public TMP_Text Difficulty;
    public TMP_Text targetsLeft;
    public TMP_Text timerText; 
    public Slider timerSlider;

    public void UpdateScore(int _score)
    {
        scoreText.text = "Score:" + _score;
    }

    public void UpdateTimer(float _timer)
    {
        timerText.text = "Time Remaining:" + _timer.ToString("F2");
        timerSlider.value = _timer;

        timerText.color = _timer < 10f ? Color.red : Color.white;
      
    }

    public void UpdateTargetsleft(int _targetsleft)
    {
        targetsLeft.text = "Targets Left:" + _targetsleft;
    }

    public void UpdateDifficulty(int _difficulty)
    {
        Difficulty.text = "Difficulty:" + _difficulty;
    }







}
