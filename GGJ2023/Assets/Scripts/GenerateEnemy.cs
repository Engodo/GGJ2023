using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public float leftBound = -5F;
    public float rightBound = 5F;

    void Start()
    {
        //SpawnEnemy();
    }

    void Update()
    {
        
    }


    void SpawnEnemy()
    {
        GameObject enemyClone;

        enemyClone = Instantiate(Enemy, this.transform.position, this.transform.rotation);

        float x = Random.Range(leftBound, rightBound);
        transform.position = new Vector3(x, this.transform.position.y, 0);
    }
}
