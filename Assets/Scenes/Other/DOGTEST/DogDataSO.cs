using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/DogDataSO")]
public class DogDataSO : ScriptableObject
{
    [SerializeField]
    private string Breed;
    [SerializeField]
    private float Health;
    [SerializeField]
    public GameObject DogPrefab;
    [SerializeField]
    private float Energy;
    [SerializeField]
    private float Hunger;
    [SerializeField]
    private float Speed;
}
