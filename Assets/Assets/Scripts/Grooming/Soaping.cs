using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soaping : MonoBehaviour
{
    public GameObject SoapSprite;
    public bool canSpawnSoap = true;

    public float timer;

    private void Update()
    {
        if(!canSpawnSoap)
        {
            timer += Time.deltaTime;

            if(timer >= 2)
            {
                timer = 0;
                canSpawnSoap = true;
            }    
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Head" || collision.name == "Body" || collision.name == "Legs")
        {
            collision.GetComponent<SoapingHP>()._hp += 10;

            if (canSpawnSoap)
            {
                Instantiate(SoapSprite, transform.position, Quaternion.identity);
                canSpawnSoap = false;
            }
        }
    }
}
