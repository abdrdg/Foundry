using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/InventoryDataSO")]
public class PlayerInventoryDataSO : ScriptableObject
{
    [SerializeField]
    public List<GameObject> Dogs;
}
