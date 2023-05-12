using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public FoodSpawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Good Food"))
        {
            
            spawner.goodPool.Release(collision.gameObject);

        }
        else if (collision.gameObject.CompareTag("Bad Food"))
        {
            
            spawner.badPool.Release(collision.gameObject);
        }
        else
        {
            Debug.Log("Game object doesn't have Tag");
        }
    }
}
