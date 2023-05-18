using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject panel;
    public bool boolIsActive = false;

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
        if(!boolIsActive)
        {
            boolIsActive = true;
        }    
        else
        boolIsActive = false;
    }
}
