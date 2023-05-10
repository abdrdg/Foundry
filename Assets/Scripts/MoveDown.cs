using UnityEngine;

public class MoveDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3(transform.position.x - 3.0f * Time.deltaTime, transform.position.y, transform.position.z);
        //Debug.Log(this.gameObject.transform.position);

        if(transform.position.x  < -10)
        {
            Destroy(gameObject);
        }
    }
}
