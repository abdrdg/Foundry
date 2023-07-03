using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject panel;
    public bool boolIsActive = false;
    public SelectionManager sm;
    void Update()
    {
        if(!boolIsActive)
        {
            panel.SetActive(false);
        }

        else if (boolIsActive)
        {
            panel.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if(sm._dogSelected == null)
        sm._dogSelected = gameObject;
        else
        sm._dogSelected = null;

        if (!boolIsActive)
        {
            
            boolIsActive = true;
        }    
        else
        boolIsActive = false;
    }
}
