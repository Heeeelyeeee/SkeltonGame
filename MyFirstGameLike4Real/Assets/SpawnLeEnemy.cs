using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine; 

public class SpawnLeEnemy : MonoBehaviour
{
    public GameObject GreenSkeleton;
    public GameObject AllCounter;
    public int Spawnrate = 3;
    Vector2 WhereToSpawn;
    public float CurentEnemyCount = 0;

    void Start(){
        Enemycounter EC = GetComponent<Enemycounter>();
        float Max = AllCounter.GetComponent<Enemycounter>().Wave1Green;

        for (int j = 0; j< 1000; j += Spawnrate)
        {
            if (Max >= CurentEnemyCount)
            {
                Invoke("SpawnGreen", j);
                CurentEnemyCount += 1;
            }
          
        }
    }


    public void SpawnGreen()
    {
        WhereToSpawn = new Vector2((transform.position.x + Random.Range(2f, -2f)), (transform.position.y + Random.Range(2f, -2f)));

        Instantiate(GreenSkeleton, WhereToSpawn, Quaternion.identity);
    }

}
