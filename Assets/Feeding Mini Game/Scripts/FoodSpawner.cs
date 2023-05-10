using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject[] foods;
    // Start is called before the first frame update
    void Start()
    {
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
            CreateItems0();
        }
    }

    private void CreateItems0()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.1f, 0.9f), 4.36f, 0));
        pos.z = 0.0f;

        var food = foods[Random.Range(0, foods.Length)];
        Instantiate(food, pos, Quaternion.identity);
    }
}
