using UnityEngine;

public class OrderInLayer : MonoBehaviour
{
    private int originalLayerOrder;
    private SelectionManager selectionManager;

    private void Start()
    {
        selectionManager = FindObjectOfType<SelectionManager>();
        originalLayerOrder = GetComponent<Canvas>().sortingOrder;
    }

    private void Update()
    {
        if (selectionManager._dogSelected != null)
        {
            // Dog Selected variable is not empty
            GetComponent<Canvas>().sortingOrder = 0;
        }
        else
        {
            // Dog Selected variable is empty
            GetComponent<Canvas>().sortingOrder = originalLayerOrder;
        }
    }
}
