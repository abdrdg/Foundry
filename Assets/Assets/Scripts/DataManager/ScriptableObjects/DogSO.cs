using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class DogSO : ScriptableObject
{
    [SerializeField] public string _dogType;
    [SerializeField] public string _dogName;
    [SerializeField] public int _obedience;
    [SerializeField] public int _beauty;
    [SerializeField] public int _agility;
    [SerializeField] public int _health;
    [SerializeField] public int _energy;
    [SerializeField] public int _mood;
    [SerializeField] public Sprite _image;
}
