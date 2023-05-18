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

    public Vector3 _positionToMove;
    void Awake()
    {
        Dog = GameObject.FindGameObjectWithTag("Player");
        _positionToMove = new Vector3(Dog.transform.position.x, Dog.transform.position.y, Dog.transform.position.z);
        Time.timeScale = 1.0f;
    }

    public void Update()
    {
        #region GameLoop 
        if (Dog != null)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Input.GetMouseButton(0))
            {
               
                if (mousePosition.y < Dog.transform.position.y)
                {
                    _positionToMove = new Vector3(Dog.transform.position.x, mousePosition.y, Dog.transform.position.z);

                }
               
                else if (mousePosition.y > Dog.transform.position.y)
                {
                    _positionToMove = new Vector3(Dog.transform.position.x, mousePosition.y, Dog.transform.position.z);
                }
            }   
            Dog.transform.position = Vector3.MoveTowards(Dog.transform.position, _positionToMove, 2f * Time.deltaTime);//moves the dog 
        }
        #endregion 
    }

}
