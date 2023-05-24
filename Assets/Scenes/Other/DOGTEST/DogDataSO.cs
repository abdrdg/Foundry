using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/DogDataSO")]
public class DogDataSO : ScriptableObject
{
    [SerializeField]
    public string Breed;
    [SerializeField]
    public float Health;
    [SerializeField]
    public Sprite DogSprite;
    [SerializeField]
    public float Energy;
    [SerializeField]
    public float Hunger;
    [SerializeField]
    public float Speed;
    [SerializeField]
    public string DogName;

    void OnEnable()
    {
        DogName = GenerateName();
    }
    private string GenerateName()
    {
        List<string> dogNames = new List<string>{"Allan", "Khim", "JP", "John", "Daintsu"};
        return dogNames[Random.Range(0, dogNames.Count)];
    }
        
}
