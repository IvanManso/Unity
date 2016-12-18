using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class  Respawn : MonoBehaviour
{

    public List<GameObject> animals;
    public float spawnTime = 5f;
    public Transform[] spawnPoints;

    // Use this for initialization
    void Start()
    {
        animals = new List<GameObject>();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
/*        if (playerHealth.currentHealth <= 0)
        {
            return;
        }*/
        int index = Random.Range (0, animals.Count);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(animals[index], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

}