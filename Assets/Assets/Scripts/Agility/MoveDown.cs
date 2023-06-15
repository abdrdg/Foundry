using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.5f;
        if(speed>=5)
        {
            speed = 5;
        }
        this.gameObject.transform.position = new Vector3(transform.position.x - 3.0f * (Time.deltaTime*speed), transform.position.y,
            transform.position.z);
        //Debug.Log(this.gameObject.transform.position);

        if(transform.position.x  < -10)
        {
            Destroy(gameObject);
        }
    }
}
