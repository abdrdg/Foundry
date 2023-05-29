using UnityEngine;

public class GroomingManager : MonoBehaviour
{
    public GameObject Soap;
    public void EquipSoap()
    {
        Instantiate( Soap,transform.position,Quaternion.identity );
    }
}
