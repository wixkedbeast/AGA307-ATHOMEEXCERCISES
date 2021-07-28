using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{

    public TMP_Text scoreText;
    public TMP_Text Difficulty;
    public TMP_Text TargetsLeft;

    public void UpdateScore(int _score)
    {
        scoreText.text = "Score:" + _score;
    }

    public void UpdateDifficulty(int _difficulty)
    {
        Difficulty.text = "Difficulty:" + _difficulty;
    }

    public void UpdateTargetsLeft(int _targetsleft)
    {
        TargetsLeft.text = "TargetsLeft:" + _targetsleft;
    }

    
}
