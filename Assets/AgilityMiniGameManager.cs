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
    float currentLerpTime;

    public float Distance;
    public float MovePower = 2.0f;
    public Vector2 mousePosition;

    public Vector3 _positionToMove;
    void Awake()
    {
        Dog = GameObject.FindGameObjectWithTag("Player");
    }

    public void Update()
    {
        if (Dog != null)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            this.gameObject.transform.position = mousePosition;

            Distance = Mathf.Sqrt((Dog.transform.position.x - this.transform.position.x) * (Dog.transform.position.x - this.transform.position.x)
               + (Dog.transform.position.y - this.transform.position.y) * (Dog.transform.position.y - this.transform.position.y));



            if (Input.GetMouseButtonDown(0))
            {
                if (mousePosition.y < 0 && Dog.transform.position.y > -2.0f)
                {
                    _positionToMove = new Vector3(Dog.transform.position.x, Dog.transform.position.y - MovePower, Dog.transform.position.z);

                }

                if (mousePosition.y > 0 && Dog.transform.position.y < 2.0f)
                {
                    _positionToMove = new Vector3(Dog.transform.position.x, Dog.transform.position.y + MovePower, Dog.transform.position.z);
                }
            }

            Dog.transform.position = Vector3.MoveTowards(Dog.transform.position, _positionToMove, 2f * Time.deltaTime);
        }
    }

}
