using UnityEngine;

public class Dog : MonoBehaviour
{
    public DogDataSO breed;
    public float health;
    public float energy;
    public float hunger;
    public float speed;
    public string dogName;

    void Start()
    {
        if(!LoadData())
        {
            Initialize();
        }
    }

    private void Initialize()
    {
        this.health = breed.Health;
        this.energy = breed.Energy;
        this.hunger = breed.Hunger;
        this.speed = breed.Speed;
        this.dogName = breed.DogName;
        
        gameObject.GetComponent<SpriteRenderer>().sprite = breed.DogSprite;
        gameObject.name = "Dog_" + breed.Breed + "_" + this.dogName;
    }

    public void Bark()
    {
        //Bark
    }

    public bool SetName(string name)
    {
        dogName = name;
        SaveData();
        return false;
    }

    public bool SaveData()
    {
        //Save current stats
        return false;
    }

    public bool LoadData()
    {
        //Overwrite initial stats
        return false;
    }    
}
