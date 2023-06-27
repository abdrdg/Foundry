using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfBrushing : MonoBehaviour
{
    public BrushingHP Head;
    public BrushingHP Body;
    public BrushingHP Tails;
    public GetDogData dogStats;
    public DataManager dogManager;
    public GameObject manager;
    private bool statsAdded;
    void Start()
    {
        statsAdded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Head._hp >= 100 && Body._hp >= 100 && Tails._hp >= 100)
        {
            if(statsAdded==false)
            {
                dogStats._dogData.Agility += 1;
                dogStats._dogData.Obedience += 1;
                dogStats._dogData.Health += 1;
                dogStats._dogData.Energy += 1;
                dogStats._dogData.Mood += 1;
                dogManager.Save(dogStats._dogData, "Test Dog");
                statsAdded = true;
            }
            
            manager = GameObject.Find("Game Manager");
            manager.GetComponent<GroomingManager>().NextTool();
            Destroy(Head);
            Destroy(Body);
            Destroy(Tails);
            Destroy(this.gameObject.GetComponent<EndOfBrushing>());

        }
    }
}
