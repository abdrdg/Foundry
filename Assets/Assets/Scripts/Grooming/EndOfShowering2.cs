using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfShowering2 : MonoBehaviour
{
    public Showering2HP Head;
    public Showering2HP Body;
    public Showering2HP Tails;
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
            Destroy(this.gameObject.GetComponent<EndOfShowering2>());
        }
    }
}
