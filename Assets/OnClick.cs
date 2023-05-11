using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject panel;

    private void OnMouseDown()
    {
        panel.SetActive(true);
    }
}
