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
            yield return new WaitForSeconds(UnityEngine.Random.Range(spawnTimeInterval * 0.5f, spawnTimeInterval * 1.5f));
            foodBowl.ChangeAnim();

            int numFoodToSpawn = UnityEngine.Random.Range(1, 3); // Randomly determine the number of food items to spawn (either 1 or 2)

            for (int i = 0; i < numFoodToSpawn; i++)
            {
                CreateItems();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 0.3f)); // Delay between spawning each food item
            }
        }
    }


    private void CreateItems()
{
    Vector3 pos1 = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.1f, 0.9f), 1.36f, 0));
    pos1.z = 0.0f;

    Vector3 pos2 = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.1f, 0.9f), 1.36f, 0));
    pos2.z = 0.0f;

    int totalWeight = goodFoodWeight + badFoodWeight;
    var randomFood1 = Random.Range(0, totalWeight - 1);
    var randomFood2 = Random.Range(0, totalWeight - 1);

    if (randomFood1 < goodFoodWeight)
    {
        badFoodWeight++;
        var goodfood = goodPool.Get();
        goodfood.transform.position = pos1;
    }
    else
    {
        goodFoodWeight++;
        var badfood = badPool.Get();
        badfood.transform.position = pos1;
    }

    if (randomFood2 < goodFoodWeight)
    {
        badFoodWeight++;
        StartCoroutine(DelayedSpawn(pos2, true));
    }
    else
    {
        goodFoodWeight++;
        StartCoroutine(DelayedSpawn(pos2, false));
    }
}

private IEnumerator DelayedSpawn(Vector3 position, bool spawnGoodFood)
{
    yield return new WaitForSeconds(0.3f);

    if (spawnGoodFood)
    {
        var goodfood = goodPool.Get();
        goodfood.transform.position = position;
    }
    else
    {
        var badfood = badPool.Get();
        badfood.transform.position = position;
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
