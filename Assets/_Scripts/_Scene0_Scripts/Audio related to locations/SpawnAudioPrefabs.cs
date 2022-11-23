using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAudioPrefabs : MonoBehaviour
{
    [SerializeField] private Transform[] spawnLocations;
    [SerializeField] private GameObject[] WhatToSpawn;
    [SerializeField] private GameObject[] WhatToSpawnClone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void spawnAudioPrefab (int Num)
    {
        WhatToSpawnClone[Num] = Instantiate(WhatToSpawn[Num], spawnLocations[Num].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
