using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wrld;
using Wrld.Space;
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] enemyPositions;
    [Header("Number of enemies to generate (Max. 10)")]
    public int numberOfEnemiesToGenerate;
    // Start is called before the first frame update
    void Awake()
    {
        // Api.Instance.BuildingsApi.

        //Generation of enemies
        GenerateAllEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateAllEnemies()
    {
        for(int i=0;i<numberOfEnemiesToGenerate;i++)
        {
            Instantiate(enemyPrefab, enemyPositions[i]);
        }
    }
}
