using UnityEngine;
using UnityEngine.UI;

public class PanelClose : MonoBehaviour
{
    public GameObject panelToClose;
    public GameObject panelToOpen;
    public GameObject dog;
    public SelectionManager sm;

    private Button button;

    private void Start()
    {
        dog = sm._dogSelected;
        button = GetComponent<Button>();
        button.onClick.AddListener(SwitchPanels);
    }

    private void SwitchPanels()
    {
        panelToClose.SetActive(false);
        panelToOpen.SetActive(true);
        dog.SetActive(!dog.activeSelf);
    }
}