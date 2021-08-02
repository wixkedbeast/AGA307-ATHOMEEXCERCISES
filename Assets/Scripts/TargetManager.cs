using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType
{
    Small,
    Medium,
    Large
}

public class TargetManager : Singleton<TargetManager>
{

    public Transform[] spawnPoints;
    public GameObject[] targetTypes;
    
    public List<GameObject> targets;
    public GameObject player;

    public float spawnDelay = 2;
    public GameObject moveToPos;
    public float timer;
   

    void Start()
    {
        

        

        StartCoroutine(SpawnWithDelay());

        for (int i = 0; i < 50; i++)
        {
            Debug.Log("Current number :" + i);
           
        }

        
    }







    IEnumerator SpawnWithDelay()
    {
        int rndTarget = Random.Range(0, targetTypes.Length);
        int rndSpawn = Random.Range(0, spawnPoints.Length);
        GameObject go = Instantiate(targetTypes[rndTarget], spawnPoints[rndSpawn]);
        
        targets.Add(go);
        _UI.UpdateTargetsleft(targets.Count);
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(SpawnWithDelay());


    }

    void SpawnTarget()
    {

        int rndTarget = Random.Range(0, targetTypes.Length);
        for (int i = 0; i <spawnPoints.Length; i++)
        {
            GameObject go = Instantiate(targetTypes[0], spawnPoints[i]);
            targets.Add(go);
        }

        for (int i = 0; i <targets.Count; i ++)
        {
            Debug.Log(targets[i].name);
            Destroy(targets[i]);
            
        }

        

      

    }

    void SpawnRandom()
    {
        int rndSpawn = Random.Range(0, spawnPoints.Length);
        int rndEnemy = Random.Range(0, targetTypes.Length);

        GameObject go = Instantiate(targetTypes[0], spawnPoints[rndSpawn]);
        targets.Add(go);
    }

    void Despawn()
    {
        Destroy(targets[0]);
        targets.Remove(targets[0]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            SpawnTarget();

        if (Input.GetKeyDown(KeyCode.O))
            Despawn();

        if (Input.GetKeyDown(KeyCode.R))
            GenerateRandomNumber();

        if (Input.GetKey(KeyCode.I))
            SpawnRandom();
    }

    void GenerateRandomNumber()
    {
        float rnd = Random.Range(0f, 4f);
        Debug.Log("Random number is:" + rnd);
    }

    private void OnEnable()
    {
        GameEvents.OnTargetDied += TargetDied;
    }

    private void OnDisable()
    {
        GameEvents.OnTargetDied += TargetDied;
    }


    public void TargetDied(Target _target)
    {
        targets.Remove(_target.gameObject);
        Destroy(_target.gameObject);
        print(targets.Count);
        _UI.UpdateTargetsleft(targets.Count);
    }

   






}
