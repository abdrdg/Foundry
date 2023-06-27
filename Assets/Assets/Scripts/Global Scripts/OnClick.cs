using UnityEngine;
using UnityEngine.Events;

public class OnClick : MonoBehaviour
{
    public GameObject panel;
    public UnityEvent onSelect;
    public UnityEvent onDeselect;

    private bool isSelected = false;

    public bool IsSelected
    {
        get { return isSelected; }
        set
        {
            isSelected = value;
            UpdateSelectionState();
        }
    }

    private void Start()
    {
        UpdateSelectionState();
    }

    private void UpdateSelectionState()
    {
        if (isSelected)
        {
            gameObject.tag = "IsSelected";
            panel.SetActive(true);
            onSelect.Invoke();
        }
        else
        {
            gameObject.tag = "Untagged";
            panel.SetActive(false);
            onDeselect.Invoke();
        }
    }

    private void OnMouseDown()
    {
        isSelected = !isSelected;
        UpdateSelectionState();
    }
}
