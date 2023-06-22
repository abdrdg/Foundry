using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DryingHP : MonoBehaviour
{
    public float _hp;
    private void Update()
    {
        if (_hp >= 100)
        {
            _hp = 100;
        }
    }
}
