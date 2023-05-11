using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class DogParent : MonoBehaviour
{
    public DogData _dogData;
    public DataManager dataManager;
    public string _dogName;
    public string _dogType;
    public int Obedience;
    public int Agility;
    public int Health;
    public int Energy;
    public int Mood;

    void SaveData()
    {
        _dogData._dogName = this._dogName;
        _dogData._dogType = this._dogType;
        _dogData.Obedience = this.Obedience;
        _dogData.Agility = this.Agility;
        _dogData.Health = this.Health;
        _dogData.Energy = this.Energy;
        _dogData.Mood = this.Mood;
    }

    void LoadData()
    {
        this._dogName = _dogData._dogName;
        this._dogType = _dogData._dogType;
        this.Obedience = _dogData.Obedience;
        this.Agility = _dogData.Agility;
        this.Health = _dogData.Health;
        this.Energy = _dogData.Energy;
        this.Mood = _dogData.Mood;
    }

}
