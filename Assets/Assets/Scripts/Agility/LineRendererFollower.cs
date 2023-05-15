using UnityEngine;

public class LineRendererFollower : MonoBehaviour
{
    public GameObject targetObject;
    public LineRenderer lineRenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject == null)
        {
            lineRenderer.enabled = false;
        }
        else
        {
            Vector3[] positions = new Vector3[2];
            positions[0] = transform.position;
            positions[1] = targetObject.transform.position;
            lineRenderer.SetPositions(positions);
        }
    }
}
