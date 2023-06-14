using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowertheDirt : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Dirt"))
        {
            collision.gameObject.GetComponent<DirtHealth>()._hp -= 1;
        }
    }
}
