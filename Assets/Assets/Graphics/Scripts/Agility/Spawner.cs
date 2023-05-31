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

    public GameObject Obstac;

    private float spawnTimer = 0;
    private float SpawnDelay = 2.5f;

    private GameObject alpha;
    void Start()
    {
        PosRand();
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        //lanes.Clear();
        spawnTimer += Time.deltaTime;//time counter

        if (spawnTimer > SpawnDelay)
        {
           CheckRedund();
            Spawn();
            Debug.Log(iter);
            Debug.Log(lane);
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
}
