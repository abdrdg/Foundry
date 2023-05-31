using UnityEngine;

public class GroomingManager : MonoBehaviour
{
    public GameObject Soap;
    public GameObject Shower;
    public GameObject Brush;
    public void EquipSoap()
    {
        Instantiate( Soap,transform.position,Quaternion.identity );
    }

    public void EquipShower()
    {
        Instantiate(Shower, transform.position, Quaternion.identity);
    }
    public void EquipBrush()
    {
        Instantiate(Brush, transform.position, Quaternion.identity);
    }
}
