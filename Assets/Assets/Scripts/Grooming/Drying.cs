using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drying : MonoBehaviour
{
    public float _power;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Head" || collision.name == "Body" || collision.name == "Legs")
        {
            collision.GetComponent<DryingHP>()._hp += _power;
        }
    }
}
