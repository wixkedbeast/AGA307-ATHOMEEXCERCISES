using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
   protected static GameManager _GM { get { return GameManager.instance; } }

   protected static TargetManager _TM { get { return TargetManager.instance; } }

   public bool isEven(int _value)
    {
        return _value % 1 == 0;
    }
  
}
