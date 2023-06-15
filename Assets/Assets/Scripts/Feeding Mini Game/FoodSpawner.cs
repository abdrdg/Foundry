using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class FoodSpawner : MonoBehaviour
{
    public GameObject[] foods;
    public ObjectPool<GameObject> goodPool;
    public ObjectPool<GameObject> badPool;
    public GameObject foodGetter;
    public BowlCollider foodBowl;
    private int goodFoodWeight = 1;
    private int badFoodWeight = 1;

    [SerializeField] private float spawnTimeInterval = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.1f, 0.9f), 4.36f, 0));
        pos.z = 0.0f;

        goodPool = CreatePool(pos, foods[1], 1, 8);
        badPool = CreatePool(pos, foods[0], 1, 8);

        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTimeInterval);
            foodBowl.ChangeAnim();
            CreateItems();
        }
    }

    private void CreateItems()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.1f, 0.9f), 4.36f, 0));
        pos.z = 0.0f;

        int totalWeight = goodFoodWeight + badFoodWeight;
        var randomFood = Random.Range(0, totalWeight - 1);

        if (randomFood < goodFoodWeight)
        {
            badFoodWeight++;
            var goodfood = goodPool.Get();
            goodfood.transform.position = pos;
        }
        else
        {
            goodFoodWeight++;
            var badfood = badPool.Get();
            badfood.transform.position = pos;
        }
    }

    public ObjectPool<GameObject> CreatePool(Vector3 pos, GameObject Objectprefab, int minAmount, int maxAmount)
    {
        var pool = new ObjectPool<GameObject>(() =>
        {
            return Instantiate(Objectprefab, pos, Quaternion.identity);
        }, food =>
        {
            food.gameObject.SetActive(true);

        }, food =>
        {
            food.gameObject.SetActive(false);

        }, food =>
        {
            Destroy(food);
        }, false, minAmount, maxAmount);

        return pool;
    }
}
