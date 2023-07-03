using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brushing : MonoBehaviour
{
    public float _power;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Head" || collision.name == "Body" || collision.name == "Legs")
        {
           if (collision.GetComponent<BrushingHP>() != null)
            {
                collision.GetComponent<BrushingHP>()._hp += _power;
            }
        }
    }
}
