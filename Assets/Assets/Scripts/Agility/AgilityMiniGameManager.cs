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
    public Vector2 mousePosition, _positionToMove;

    public GameObject Heart;

    public List<GameObject> LiveSprites;

    public int _maxLives = 3;
    public int _curLives;

    void Awake()
    {
        _curLives = _maxLives;
        Dog = GameObject.FindGameObjectWithTag("Player");
        _positionToMove = new Vector3(Dog.transform.position.x, Dog.transform.position.y, Dog.transform.position.z);
        Time.timeScale = 1.0f;

        for (int i = 0; i < _maxLives; i++)
        {
            LiveSprites.Add(Instantiate(Heart, new Vector3(-9.85f + i, 5,
                transform.position.z), Quaternion.identity));
            
        }
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
            _positionToMove.y = Mathf.Clamp(_positionToMove.y, -4f, 2.2f);
            Dog.transform.position = Vector3.MoveTowards(Dog.transform.position, _positionToMove, 2f * Time.deltaTime);//moves the dog 
        }
        #endregion 
    }

    public void TakeDamage()
    {
        Destroy(LiveSprites[_curLives - 1]);
        
        if(_curLives < 0)
        {
            _curLives = 0;
        }
    }

}
