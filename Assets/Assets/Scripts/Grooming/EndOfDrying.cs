using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfDrying : MonoBehaviour
{
    public DryingHP Head;
    public DryingHP Body;
    public DryingHP Tails;
    public GameObject manager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Head._hp >= 100 && Body._hp >= 100 && Tails._hp >= 100)
        {
            manager = GameObject.Find("Game Manager");
            manager.GetComponent<GroomingManager>().NextTool();
            Destroy(Head);
            Destroy(Body);
            Destroy(Tails);
            Destroy(this.gameObject.GetComponent<EndOfDrying>());
        }
    }
}
