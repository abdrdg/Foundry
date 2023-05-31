using UnityEngine;

public class GroomingManager : MonoBehaviour
{
    public GameObject Soap;
    public GameObject Shower;
    public GameObject Dryer;
    public void EquipSoap()
    {
        Instantiate(Soap, transform.position, Quaternion.identity);
    }

    public void EquipShower()
    {
        Instantiate(Shower, transform.position, Quaternion.identity);
    }

    public void EquipDryer()
    {
        Instantiate(Dryer, transform.position, Quaternion.identity);
    }
}
