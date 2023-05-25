using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> SpawnPos = new List<GameObject>();

    public bool GL = false;
    
    public int lane = 0;
    public int iter = 0;
    protected int rng;
    protected int obstacNum;

    public GameObject Obstac;

    private float spawnTimer = 0;
    private float SpawnDelay = 2.5f;

    private GameObject alpha;

    
    void Start()
    {
        ObstacleRNG();
        TestMultiObstac();
    }

    // Update is called once per frame
    void Update()
    {
        //lanes.Clear();
        spawnTimer += Time.deltaTime;//time counter

        if (spawnTimer > SpawnDelay)
        {
            //checkredund();
            //spawn();
            ObstacleRNG();
            TestMultiObstac();
            spawnTimer = 0;
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
        rng = Random.Range(0, 4);
        alpha = SpawnPos[rng];
        lane = rng;
    }

    void ObstacleRNG()
    {
        obstacNum = Random.Range(0, 5);
    }

    void TestMultiObstac()
    {
        for (int i = 0; i < obstacNum; i++)
        {
            CheckRedund();
            Spawn();
        }
    }
}
