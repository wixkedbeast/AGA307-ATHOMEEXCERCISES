using System.Collections;
using System.Collections.Generic;
using System;

public static class GameEvents
{
    public static event Action<Target> OnTargetHit = null;
    public static event Action<Target> OnTargetDied = null;
    public static event Action<Difficulty> OnDifficultyChanged = null;
    

    public static void ReportTargetHit(Target _target)
    {
        OnTargetHit?.Invoke(_target);
        
    }

    public static void ReportTargetDied(Target _target)
    {
        OnTargetDied?.Invoke(_target);
    }

    public static void ReportChangeDifficulty(Difficulty _difficulty)
    {
        OnDifficultyChanged?.Invoke(_difficulty);
    }

   
}
