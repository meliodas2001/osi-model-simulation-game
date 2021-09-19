using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpanner : MonoBehaviour
{
    public Transform spanner1, spanner2, spanner3;
    private float spawnTimer = 2;
    private float timer = 0;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>spawnTimer)
        {
            spawnEnemy();
            timer = 0;
        }
    }
    
    void spawnEnemy()
    {
        int n = Random.Range(1, 3);
        //int n = 1;
        Vector3 positionReference = new Vector3(0,0,0);
        if (n == 1)
            positionReference = spanner1.position;
        if (n == 2)
            positionReference = spanner2.position;
        if (n == 3)
            positionReference = spanner3.position;
        //Instantiate(enemyPrefab, positionReference, Quaternion.identity);
        Instantiate(enemyPrefab, positionReference, enemyPrefab.transform.rotation);
    }
}
