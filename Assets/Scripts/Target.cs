using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    
   int health = 30;

    public void Hit()
    {
        health -= 10;

        if(health <= 0)
        {
            Destroy(gameObject, 2);
        }
        

    }

}
