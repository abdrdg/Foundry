using UnityEngine;

public class DogSpawner : MonoBehaviour
{
    [SerializeField]
    private PlayerInventoryDataSO playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject dog in playerInventory.Dogs)
        {
            Instantiate(dog);
        }
    }
}
