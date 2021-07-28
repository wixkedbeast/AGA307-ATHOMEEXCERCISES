using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : GameBehaviour
{
    float baseSpeed = 4;
    float baseHealth = 100;
    float mySpeed;
    float myHealth;
    public Transform moveToPos;
    Vector3 startPos;

    public TargetType targetType;

    int health = 30;
    float moveDistance = 500;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Move());
        }
        
    }

    public void Hit()
    {
        health -= 10;

        if (health <= 0)
        {
            Destroy(gameObject, 2);
        }




    }

    IEnumerator Move()
    {
        for (int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
        }

        transform.Rotate(Vector3.up * 180);
        yield return new WaitForSeconds(3);
        StartCoroutine(Move());
    }

    void Setup()
    {
        switch (targetType)
        {
            case TargetType.Small:
                mySpeed = baseSpeed * 2;
                myHealth = baseHealth / 1.5f;
                break;
            case TargetType.Medium:
                mySpeed = baseSpeed * 3;
                myHealth = baseHealth / 2.5f;
                break;
            case TargetType.Large:
                mySpeed = baseSpeed * 4;
                myHealth = baseHealth / 3.5f;
                break;
            default:
                mySpeed = baseSpeed;
                myHealth = baseHealth;
                break;



        }
    }
    

   


}
