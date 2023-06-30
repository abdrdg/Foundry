using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject panel;
    public bool boolIsActive = false;
    public SelectionManager sm;

    private void Update()
    {
        if (!boolIsActive)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (sm._dogSelected == null)
        {
            sm._dogSelected = gameObject;
        }
        else if (sm._dogSelected != gameObject)
        {
            sm._dogSelected = gameObject;
        }

        else if(gameObject == null)
        {
            sm._dogSelected = null;
        }
        else
        {
            sm._dogSelected = null;
        }

        boolIsActive = sm._dogSelected != null;
    }
}
