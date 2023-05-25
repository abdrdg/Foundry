using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlMovement : MonoBehaviour
{
    public GameObject foodBowl;
    Vector3 offset;
    private float minX;
    private float maxX;
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
                CalculateScreenBounds();
            }
        }
        if (foodBowl)
        {
            float clampedX = Mathf.Clamp(mousePosition.x + offset.x, minX, maxX);
            Vector3 newPosition = new(clampedX, foodBowl.transform.position.y, foodBowl.transform.position.z);
            foodBowl.transform.position = newPosition;
        }
        if (Input.GetMouseButtonUp(0) && foodBowl)
        {
            foodBowl = null;
        }

    }
    void CalculateScreenBounds()
    {
        float objectWidth = foodBowl.GetComponent<Renderer>().bounds.size.x;
        minX = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x + (objectWidth / 2f);
        maxX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x - (objectWidth / 2f);
    }
}
