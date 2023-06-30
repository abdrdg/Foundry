using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfBrushing : MonoBehaviour
{
    public BrushingHP Head;
    public BrushingHP Body;
    public BrushingHP Tails;
    public GetDogSO dogStats;
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
                dogStats._agility += 1;
                dogStats._obedience += 1;
                dogStats._health += 1;
                dogStats._energy += 1;
                dogStats._mood += 1;
                dogStats.ApplyStatsInData();
                dogStats.SaveOnDogData();
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
