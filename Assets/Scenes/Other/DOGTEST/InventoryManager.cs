using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public PlayerInventoryDataSO playerInventory;
    public float minXSpawn;
    public float maxXSpawn;
    public float minYSpawn;
    public float maxYSpawn;
    void Start()
    {
        foreach(Dog ownedDog in playerInventory.OwnedDogs)
        {
            Instantiate(ownedDog, new Vector3(Random.Range(minXSpawn, maxXSpawn), Random.Range(minYSpawn, maxYSpawn)), Quaternion.Euler(0,0,0));
        }
    }
    void Update()
    {
        if( Input.GetMouseButtonDown(0) )
     {
         Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
         RaycastHit hit;
         
         if( Physics.Raycast( ray, out hit, 100 ) )
         {
             playerInventory.OwnedDogs.Add(hit.transform.gameObject.GetComponent<Dog>());
         }
     }
    }
}
