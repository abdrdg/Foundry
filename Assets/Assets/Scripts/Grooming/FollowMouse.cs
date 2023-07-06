using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float raycastDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        // Cast a ray from the raycastOrigin position in the forward direction
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = mousePosition;
    }

}
