using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PanelClose : MonoBehaviour, IPointerClickHandler
{
    public Canvas targetCanvas;
    public int newSiblingIndex = 3;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (targetCanvas != null)
        {
            targetCanvas.transform.SetSiblingIndex(newSiblingIndex);
        }
        else
        {
            Debug.LogWarning("No target canvas assigned to the script.");
        }
    }
}
