using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Gamestate
{
    Title,
    InGame,
    GameOver,
}

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}

public class GameManager : Singleton<GameManager>
{
    
    public Gamestate gameState;
    public Difficulty difficulty;

    public int score;
    int scoreMultiplier = 1;

    


    // Start is called before the first frame update
    void Start()
    {
       switch(difficulty)
        {
            case Difficulty.Easy:
                scoreMultiplier = 1;
                break;
            case Difficulty.Medium:
                scoreMultiplier = 2;
                break;
            case Difficulty.Hard:
                scoreMultiplier = 3;
                break;
            default:
                scoreMultiplier = 1;
                break;
        }
    }

   

    // Update is called once per frame
    

    public void AddScore(int _points)
    {
        score += _points * scoreMultiplier;
        _UI.UpdateScore(score);


    }

    public void ChangeDifficulty(int _difficulty)
    {
        difficulty = (Difficulty)_difficulty;
    }

    void OnTargetHit(Target _target)
    {
        AddScore(10);
    }
}
