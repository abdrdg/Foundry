using UnityEngine;
using UnityEngine.Events;

public class Selectable : MonoBehaviour
{
    public GameObject panel;
    public bool isSelected = false;
    public UnityEvent onSelect;
    public UnityEvent onDeselect;

    void Update()
    {
        panel.SetActive(isSelected);
    }

    private void OnMouseDown()
    {
        if (!isSelected)
        {
            isSelected = true;
            onSelect.Invoke();
        }
        else
        {
            isSelected = false;
            onDeselect.Invoke();
        }
    }
}
