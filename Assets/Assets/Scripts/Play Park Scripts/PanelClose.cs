using UnityEngine;
using UnityEngine.UI;

public class PanelClose : MonoBehaviour
{
    public GameObject panelToClose;
    public GameObject panelToOpen;
    public SelectionManager sm;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(SwitchPanels);
    }

    private void SwitchPanels()
    {
        panelToClose.SetActive(false);
        panelToOpen.SetActive(true);
        sm.ToggleSelectedGameObject();
    }
}
