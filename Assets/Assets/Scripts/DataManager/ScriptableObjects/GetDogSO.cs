using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDogSO : MonoBehaviour
{
    [SerializeField] public DogSO dogData; //stats reference to SO (base stats)
    [SerializeField] private DogData dd; //stats to presist

    //Stats in Game
    public string _dogType;
    public string _dogName;
    public int _obedience;
    public int _beauty;
    public int _agility;
    public int _health;
    public int _energy;
    public int _mood;
    public string _fileName;
    public Sprite _image;

    public DataManager dtm;
    void Start()
    {
        _fileName = dogData._fileName;
        SetDataOnStart(); // sets SO data as base stats
        LoadSavedDogData(); // load data file if have
        ApplyStatsInData(); // apply saved data to base stats
        
        //SaveOnDogData();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            dtm.Save(dd, _fileName);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            LoadSavedDogData();
        }
    }

    public void SetDataOnStart()
    {
        this._dogType = dogData._dogType;
        this._dogName = dogData._dogName;
        this._obedience = dogData._obedience;
        this._beauty = dogData._beauty;
        this._agility = dogData._agility;
        this._health = dogData._health;
        this._energy = dogData._energy;
        this._mood = dogData._mood;
        this._image = dogData._image;
    }

    public void ApplyStatsInData()
    {
        this._obedience += dd.Obedience;
        this._beauty += dd.Beauty;
        this._agility += dd.Agility;
        this._health += dd.Health;  
        this._energy += dd.Energy;  
        this._mood += dd.Mood;
    }

    public void SaveOnDogData()
    {
        dd._dogType = this._dogType;
        dd._dogName = this._dogName;
        dd.Obedience = this._obedience;
        dd.Beauty = this._beauty;
        dd.Agility = this._agility;
        dd.Health = this._health;
        dd.Energy = this._energy;
        dd.Mood = this._mood;
    }

    public DogData ReturnDogData()
    {
        return dd;
    }

    public void LoadSavedDogData()
    {
        dd = dtm.Load(_fileName);
    }

    public void SaveDogData()
    {
        dtm.Save(dd, _fileName);
    }
}
