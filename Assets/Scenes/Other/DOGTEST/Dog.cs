using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField]
    private DogDataSO DogData;

    [SerializeField]
    public string Name;

    void Start()
    {
        Instantiate(DogData.DogPrefab, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
