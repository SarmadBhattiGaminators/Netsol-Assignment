using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    //Keeps things public to debug the values
    public GameObject bulletObject;
    public GameObject[] activeEnemies;
    public Transform[] enemyPositions;
    public GameObject objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        //Get All Activated Enemies
        EnemySpawner enemyScr = GameObject.FindObjectOfType<EnemySpawner>();

        activeEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i=0;i<activeEnemies.Length; i++)
        {
            enemyPositions[i] = activeEnemies[i].transform;
        }
    }

    public void FireMethod()
    {
        activeEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < activeEnemies.Length; i++)
        {
            enemyPositions[i] = activeEnemies[i].transform;
        }

        float minDistance=Vector3.Distance(transform.position,activeEnemies[0].transform.position);
        //Get the nearest enemy
        for(int i=1;i<activeEnemies.Length;i++)
        {
           if( Vector3.Distance(transform.position,activeEnemies[i].transform.position)<minDistance)
            {
                minDistance = Vector3.Distance(transform.position, activeEnemies[i].transform.position);
                objectToDestroy = activeEnemies[i];
            }
        }

        Instantiate(bulletObject);
    }
}
