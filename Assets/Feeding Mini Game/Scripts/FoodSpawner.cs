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
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.1f, 0.9f), 4.36f, 0));
        pos.z = 0.0f;

        goodPool = new ObjectPool<GameObject>(() =>
        {
            return Instantiate(foods[1], pos, Quaternion.identity);
        }, food =>
        {
            food.gameObject.SetActive(true);
            
        }, food =>
        {
            food.gameObject.SetActive(false);
        }, food =>
        {
            Destroy(food);
        }, false, 1, 2);

        badPool = new ObjectPool<GameObject>(() =>
        {
            return Instantiate(foods[0], pos, Quaternion.identity);
        }, food =>
        {
            food.gameObject.SetActive(true);

        }, food =>
        {
            food.gameObject.SetActive(false);
        }, food =>
        {
            Destroy(food);
        }, false, 1, 2);

        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            CreateItems();
        }
    }

    private void CreateItems()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.1f, 0.9f), 4.36f, 0));
        pos.z = 0.0f;

        var randomFood = Random.Range(0, 10);

        if(randomFood<6)
        {
            var goodfood = goodPool.Get();
            goodfood.transform.position = pos;
        }
        else if(randomFood>=6)
        {
            var badfood = badPool.Get();
            badfood.transform.position = pos;
        }
        

        //Instantiate(food, pos, Quaternion.identity);
       
    }

    

    
}
