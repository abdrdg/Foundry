using UnityEngine;

public class FollowTouch : MonoBehaviour
{
    public Vector2 mousePosition;
    public GameObject Dog;

    public float lerpTime = 1f;
    float currentLerpTime;

    public float Distance;

    public float MoveThreshold;

    public Vector3 _previousPosition;
    public Vector3 _currentPosition;
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        this.gameObject.transform.position = mousePosition;

        _currentPosition = this.gameObject.transform.position;



        //currentLerpTime += Time.deltaTime;

        //if (currentLerpTime > lerpTime)
        //{
        //    currentLerpTime = lerpTime;
        //}

        //float perc = currentLerpTime / lerpTime;
        //perc = perc * perc * perc * (perc * (6f * perc - 15f) + 10f);

        if (_previousPosition != _currentPosition)
        {
            timer += Time.deltaTime;

            if (timer > 0.5f)
            {
                _previousPosition = _currentPosition;
                timer = 0;
            }
        }

        if(Dog != null)
        {

            Distance = Mathf.Sqrt((Dog.transform.position.x - this.transform.position.x) * (Dog.transform.position.x - this.transform.position.x)
                + (Dog.transform.position.y - this.transform.position.y) * (Dog.transform.position.y - this.transform.position.y));

            Dog.transform.position = Vector3.MoveTowards(Dog.transform.position, _previousPosition, 2f * Time.deltaTime);
        }
        else
        {

        }

       //if(Dog.transform.position == _currentPosition)
       // {
       //     currentLerpTime = 0;
       // }

       // if(Distance < MoveThreshold)
       // {
       //     currentLerpTime = 0;
       // }
    }
}
