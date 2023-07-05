using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> SpawnPos = new List<GameObject>();
    
    public int lane = 0;
    public int iter = 0;
    protected int rng, obstacNum;

    public GameObject Obstac;

    private float spawnTimer = 0;
    private float SpawnDelay = 2.5f, time;

    private GameObject alpha;
    public float speed = 1;
    
    void Start()
    {
        PosRand();
        Spawn();
        StartCoroutine(delay());
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime; 
        spawnTimer += Time.deltaTime * speed;//time counter

        if (time < 15)
        {
            if (spawnTimer > SpawnDelay)
            {
                CheckRedund();
                Spawn();
                spawnTimer = 0;
            }
        }
        else
        {
            if (spawnTimer > SpawnDelay)
            {
                ObstacleRNG();
                SpawnMultiObstac();
                spawnTimer = 0;
            }
        }
    }

    void Spawn()
    {
        GameObject thing = Instantiate(Obstac, alpha.transform.position, Quaternion.Euler(0, 0, 0));
        iter = rng;//what lane has spawned
    }

    void CheckRedund()
    {
        while (lane == iter)//check that it's not spawning on the same lane
        {
            PosRand();
        }
    }

    void PosRand()//random lane
    {
        rng = Random.Range(0, 5);
        alpha = SpawnPos[rng];
        lane = rng;
    }

    void ObstacleRNG()
    {
        obstacNum = Random.Range(2, 3);
    }

    void SpawnMultiObstac()
    {
        for (int i = 0; i < obstacNum; i++)
        {
            CheckRedund();
            Spawn();
        }
    }
    IEnumerator delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            speed += 0.5f;
            if (speed >= 5)
            {
                speed = 5;
            }
        }
    }
}
