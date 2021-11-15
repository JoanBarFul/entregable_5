using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;

    void Start()
    { InvokeRepeating("SpawnObstacle", 0.5f, 3.25f); }  
    // Com que he pujat la velocitat he hagut de canviar el temps de repetició a 3.25s

    public void SpawnObstacle()
    {
        randomY = Random.Range(10, -11);
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
      
    }
}
