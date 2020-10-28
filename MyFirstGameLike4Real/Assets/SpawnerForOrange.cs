using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnerForOrange : MonoBehaviour
{
    public GameObject OrangeSkeleton;
    public GameObject AllCounter;
    public int Spawnrate = 1;
    Vector2 WhereToSpawn;
    public float CurentEnemyCount = 0;

    void Start()
    {
        Enemycounter EC = GetComponent<Enemycounter>();
        float Max = AllCounter.GetComponent<Enemycounter>().Wave1Orange;

        for (int i = 0; i < 1000; i += Spawnrate)
        {
            if (Max >= CurentEnemyCount)
            {
                Invoke("SpawnOrange", i);
                CurentEnemyCount += 1;
            }

        }
    
    }

    public void SpawnOrange()
    {

        WhereToSpawn = new Vector2((transform.position.x + Random.Range(2f, -2f)), (transform.position.y + Random.Range(2f, -2f)));
        Instantiate(OrangeSkeleton, WhereToSpawn, Quaternion.identity);
    }
}
