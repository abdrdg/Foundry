using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AgilityMiniGameManager : MonoBehaviour
{
    public GameObject Dog;
    public List<GameObject> Lanes;

    public float lerpTime = 1f;

    public float Distance;
    public float MovePower = 2f;
    public Vector2 mousePosition;

    //float Yoffset = 2.5f;

    public Vector3 _positionToMove;
    void Awake()
    {
        Dog = GameObject.FindGameObjectWithTag("Player");
        _positionToMove = new Vector3(Dog.transform.position.x, Dog.transform.position.y, Dog.transform.position.z);
    }

    public void Update()
    {
        if (Dog != null)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Input.GetMouseButton(0))
            {
                // Move dog upwards based on position of cursor if it's on top
                if (mousePosition.y < Dog.transform.position.y /*&& Dog.transform.position.y > -Yoffset*/)
                {
                    _positionToMove = new Vector3(Dog.transform.position.x, mousePosition.y, Dog.transform.position.z);

                }
                // Move dog downwards based on position of cursor if it's below
                else if (mousePosition.y > Dog.transform.position.y /*&& Dog.transform.position.y < Yoffset*/)
                {
                    _positionToMove = new Vector3(Dog.transform.position.x, mousePosition.y, Dog.transform.position.z);
                }
            }
            //if (Input.GetMouseButton(1))
            //{
            //    _positionToMove = mousePosition;
            //}
                
            Dog.transform.position = Vector3.MoveTowards(Dog.transform.position, _positionToMove, 2f * Time.deltaTime);//moves the dog 
        }
    }

}
