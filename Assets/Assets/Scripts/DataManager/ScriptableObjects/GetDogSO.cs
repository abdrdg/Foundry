using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDogSO : MonoBehaviour
{
    [SerializeField] public DogSO dogData;

    public string _dogType;
    public int _obedience;
    public int _beauty;
    public int _agility;
    public int _health;
    public int _energy;
    public int _mood;
    void Start()
    {
        SetDataOnStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetDataOnStart()
    {
        this._dogType = dogData._dogType;
        this._obedience = dogData._obedience;
        this._beauty = dogData._beauty;
        this._agility = dogData._agility;
        this._health = dogData._health;
        this._energy = dogData._energy;
        this._mood = dogData._mood;
    }
}
