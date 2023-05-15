using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlMovement : MonoBehaviour
{
    public GameObject foodBowl;
    Vector3 offset;
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = transform.position.y;
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                foodBowl = targetObject.transform.gameObject;
                offset = foodBowl.transform.position - mousePosition;
            }
        }
        if (foodBowl)
        {
            foodBowl.transform.position = mousePosition + offset;
            
        }
        if (Input.GetMouseButtonUp(0) && foodBowl)
        {
            foodBowl = null;
        }
    }
}
