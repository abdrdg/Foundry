using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfShowering : MonoBehaviour
{
    public DirtHolder head;
    public DirtHolder body;
    public DirtHolder tail;
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if(head.Dirt.Count == 0 && body.Dirt.Count == 0 && tail.Dirt.Count == 0)
        {
            manager = GameObject.Find("Game Manager");
            manager.GetComponent<GroomingManager>().NextTool();
            Destroy(head);
            Destroy(body);
            Destroy(tail);
            Destroy(this.gameObject.GetComponent<EndOfShowering>());
        }
    }
}
