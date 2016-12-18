using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class  RespawnWater : MonoBehaviour
{

    public List<GameObject> fishes;
    public float spawnTime = 5f;
    public Transform[] spawnPoints;

    // Use this for initialization
    void Start()
    {
        fishes = new List<GameObject>();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
/*        if (playerHealth.currentHealth <= 0)
        {
            return;
        }*/
        int index = Random.Range (0, fishes.Count);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(fishes[index], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

}