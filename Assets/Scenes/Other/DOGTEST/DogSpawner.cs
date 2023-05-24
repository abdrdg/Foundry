using UnityEngine;

public class DogSpawner : MonoBehaviour
{
    [SerializeField]
    private PlayerInventoryDataSO playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Dog ownedDog in playerInventory.OwnedDogs)
        {
            Instantiate(ownedDog);
        }
    }
}
