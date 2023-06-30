using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showering2 : MonoBehaviour
{
    public float _power;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Head" || collision.name == "Body" || collision.name == "Legs")
        {
            collision.GetComponent<Showering2HP>()._hp += _power;
        }
    }
}
