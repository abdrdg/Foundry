using UnityEngine;

public class GroomingManager : MonoBehaviour
{
    public GameObject Soap;
    public GameObject Shower;
    public GameObject Dryer;
    public GameObject Brush;

    protected GameObject OnMouse;
    public void EquipSoap()
    {
        AntiStack();
        OnMouse = Instantiate(Soap, transform.position, Quaternion.identity);
    }
    public void EquipShower()
    {
        AntiStack();
        OnMouse = Instantiate(Shower, transform.position, Quaternion.identity);
    }
    public void EquipDryer()
    {
        AntiStack();
        OnMouse = Instantiate(Dryer, transform.position, Quaternion.identity);
    }
    public void EquipBrush()
    {
        AntiStack();
        OnMouse = Instantiate(Brush, transform.position, Quaternion.identity);
    }

    private void AntiStack()
    {
        if (OnMouse != null)
        {
            Destroy(OnMouse);
        }
    }
}
